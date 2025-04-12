using COMP1640.Data;
using COMP1640.Models;
using COMP1640.Service;
using COMP1640.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP1640.Controllers;

[Authorize(Roles = "Teacher")]
public class TeacherController : Controller
{
    private readonly IEmailService _emailService;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IWebHostEnvironment _hostEnvironment;

    public TeacherController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment, IEmailService emailService)
    {
        _context = context;
        _userManager = userManager;
        _hostEnvironment = hostEnvironment;
        _emailService = emailService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Dashboard()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        // Get students assigned to this teacher
        var students = await _context.Users
            .Where(s => s.TutorId == user.Id)
            .Select(s => new StudentMessageViewModel
            {
                StudentId = s.Id,
                StudentName = s.FullName,
                LastMessage = _context.Messages
                    .Where(m => (m.SenderId == s.Id && m.ReceiverId == user.Id) || (m.SenderId == user.Id && m.ReceiverId == s.Id))
                    .OrderByDescending(m => m.Timestamp)
                    .Select(m => m.Content)
                    .FirstOrDefault() ?? "No messages yet"
            })
            .ToListAsync();

        // Get meetings of this teacher, sorted by deadline
        var meetings = await _context.Meetings
            .Where(m => m.TeacherId == user.Id)
            .OrderBy(m => m.Deadline) // Sort by deadline (earliest first)
            .Select(m => new MeetingViewModel
            {
                Id = m.Id,
                Name = m.Name,
                Deadline = m.Deadline,
                StudentName = _context.Users.Where(u => u.Id == m.StudentId)
                                            .Select(u => u.FullName)
                                            .FirstOrDefault(),
                RecordLink = m.RecordLink,
                MeetingLink = m.MeetingLink
            })
            .ToListAsync();

        // Create a ViewModel to pass both lists to the View
        var viewModel = new TeacherDashboardViewModel
        {
            Students = students,
            Meetings = meetings
        };

        return View(viewModel);
    }

    public async Task<IActionResult> Create()
    {
        var teacher = await _userManager.GetUserAsync(User);
        if (teacher == null) return RedirectToAction("Login", "Account");

        // Get all students assigned to this teacher
        var students = await _userManager.GetUsersInRoleAsync("Student");
        var assignedStudents = students.Where(s => s.TutorId == teacher.Id).ToList();

        ViewBag.Students = assignedStudents;
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Create(Meeting model)
    {
        var teacher = await _userManager.GetUserAsync(User);
        if (teacher == null) return RedirectToAction("Login", "Account");

        model.TeacherId = teacher.Id;

        // ✅ Ensure Deadline is stored as UTC
        model.Deadline = DateTime.SpecifyKind(model.Deadline, DateTimeKind.Utc);

        if (string.IsNullOrEmpty(model.MeetingLink))
        {
            ModelState.AddModelError("MeetingLink", "Meeting Link is required.");
            return View(model);
        }

        _context.Meetings.Add(model);

        // ✅ Add Interaction for student
        var interaction = new Interaction
        {
            TutorId = teacher.Id,
            StudentId = model.StudentId,
            Type = "just created a meeting",
            Timestamp = DateTime.UtcNow
        };

        _context.Interactions.Add(interaction);

        await _context.SaveChangesAsync();

        // ✅ Send event notification email (no meeting details)
        var student = await _context.Users.FindAsync(model.StudentId);
        if (student != null && !string.IsNullOrEmpty(student.Email))
        {
            string subject = "You have a new meeting notification";
            string body = $"Hi {student.FullName},<br><br>" +
                          "Your personal tutor has scheduled a new meeting with you.<br>" +
                          "Please <a href=\"https://your-etutoring-site.com\">log into the eTutoring system</a> to view the details.<br><br>" +
                          "Thank you,<br>eTutoring System";

            await _emailService.SendEmailAsync(student.Email, subject, body);
        }

        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> UpdateRecordLink([FromBody] UpdateRecordLinkDto model)
    {
        var meeting = await _context.Meetings.FindAsync(model.Id);
        if (meeting == null)
        {
            return NotFound();
        }

        meeting.RecordLink = model.RecordLink;
        await _context.SaveChangesAsync();

        // ✅ Add Interaction for student
        var interaction = new Interaction
        {
            TutorId = meeting.TeacherId,
            StudentId = meeting.StudentId,
            Type = "just updated meeting recording",
            Timestamp = DateTime.UtcNow
        };

        _context.Interactions.Add(interaction);
        await _context.SaveChangesAsync(); // Save interaction

        return Ok();
    }

    // DTO Class
    public class UpdateRecordLinkDto
    {
        public int Id { get; set; }
        public string RecordLink { get; set; }
    }

    public async Task<IActionResult> Document()
    {
        var userId = _userManager.GetUserId(User);

        // Check if the logged-in user is a teacher
        var isTeacher = await _userManager.IsInRoleAsync(await _userManager.FindByIdAsync(userId), "Teacher");

        IQueryable<Document> documentsQuery;

        if (isTeacher)
        {
            // Fetch all documents uploaded by the teacher and their students
            documentsQuery = _context.Documents
                .Where(d => d.TutorId == userId || d.Student.TutorId == userId);
        }
        else
        {
            // Fetch only documents uploaded by the student themselves
            documentsQuery = _context.Documents.Where(d => d.StudentId == userId);
        }

        var documents = await documentsQuery
            .Select(d => new DocumentViewModel
            {
                Id = d.Id,
                DocumentName = d.DocumentName,
                FilePath = d.FilePath,
                Author = d.Student.FullName,
                DateUploaded = d.DateUploaded.ToLocalTime(),
                Comments = d.Comments
               .OrderByDescending(c => c.CreatedAt)
                .Select(c => new CommentViewModel
                {
                    Id = c.Id,
                    Content = c.Content,
                    Author = c.Author.FullName,
                    CreatedAt = c.CreatedAt
                }).ToList()
            })
            .ToListAsync();

        return View(documents);
    }

    [HttpPost]
    public async Task<IActionResult> AddComment(int documentId, string content)
    {
        if (string.IsNullOrWhiteSpace(content))
        {
            return BadRequest("Comment cannot be empty.");
        }

        var userId = _userManager.GetUserId(User);
        var comment = new Comment
        {
            Content = content,
            AuthorId = userId,
            DocumentId = documentId,
            CreatedAt = DateTime.UtcNow
        };

        _context.Comments.Add(comment);

        await _context.SaveChangesAsync();

        var document = await _context.Documents.FirstOrDefaultAsync(d => d.Id == documentId);

        // ✅ Add Interaction for Commnet
        var interaction = new Interaction
        {
            TutorId = userId,
            StudentId = document.StudentId,
            Type = "just commented on the document",
            Timestamp = DateTime.UtcNow
        };

        _context.Interactions.Add(interaction);
        await _context.SaveChangesAsync();

        return RedirectToAction("Document");
    }

    // Show Upload Page
    public IActionResult Upload()
    {
        var userId = _userManager.GetUserId(User);
        var isTeacher = _userManager.IsInRoleAsync(_userManager.FindByIdAsync(userId).Result, "Teacher").Result;

        var model = new UploadDocumentViewModel();
        if (isTeacher)
        {
            model.Students = _context.Users.Where(u => u.TutorId == userId).ToList();
        }

        return View(model);
    }

    // Handle Document Upload
    [HttpPost]
    public async Task<IActionResult> Upload(string DocumentName, IFormFile file, string studentId)
    {
        if (file == null || file.Length == 0)
        {
            ModelState.AddModelError("", "Please select a file.");
            return View();
        }

        var userId = _userManager.GetUserId(User);
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null) return Unauthorized();

        bool isTeacher = await _userManager.IsInRoleAsync(user, "Teacher");

        string ownerId = isTeacher ? studentId : userId; // If teacher, assign to selected student; otherwise, to self

        if (isTeacher && string.IsNullOrEmpty(studentId))
        {
            ModelState.AddModelError("", "Please select a student.");
            return View();
        }

        // Save file to wwwroot/uploads
        var uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "uploads");
        if (!Directory.Exists(uploadsFolder))
        {
            Directory.CreateDirectory(uploadsFolder);
        }

        var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
        var filePath = Path.Combine(uploadsFolder, uniqueFileName);
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        // Save document details to DB
        var document = new Document
        {
            DocumentName = DocumentName,
            FilePath = $"/uploads/{uniqueFileName}", // Store relative path
            StudentId = ownerId, // Assigned student or self
            TutorId = isTeacher ? userId : user.TutorId, // If teacher, assign self as tutor
            DateUploaded = DateTime.UtcNow
        };

        _context.Documents.Add(document);
        await _context.SaveChangesAsync();

        // ✅ Add Interaction for student
        var interaction = new Interaction
        {
            TutorId = userId,
            StudentId = studentId,
            Type = "just updated new document",
            Timestamp = DateTime.UtcNow
        };

        _context.Interactions.Add(interaction);

        await _context.SaveChangesAsync();

        // ✅ Send email to student (notification only)
        var student = await _context.Users.FindAsync(ownerId);
        if (student != null && !string.IsNullOrEmpty(student.Email))
        {
            string subject = "New Document Uploaded";
            string body = $"Hi {student.FullName},<br><br>" +
                          "A new document has been uploaded to your eTutoring profile.<br>" +
                          "Please <a href=\"https://your-etutoring-site.com\">log into the eTutoring system</a> to view it.<br><br>" +
                          "Thank you,<br>eTutoring System";

            await _emailService.SendEmailAsync(student.Email, subject, body);
        }


        return RedirectToAction("Document");
    }

    [HttpPost]
    public async Task<IActionResult> DeleteDocument(int id)
    {
        var userId = _userManager.GetUserId(User);
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        bool isTeacher = await _userManager.IsInRoleAsync(user, "Teacher");

        var document = await _context.Documents.FirstOrDefaultAsync(d => d.Id == id);

        if (document == null)
        {
            return NotFound();
        }

        // Only allow deletion if:
        // 1. The user is a teacher and is the tutor of the document owner.
        // 2. The user is a student and owns the document.
        if (isTeacher && document.TutorId == userId || document.StudentId == userId)
        {
            // Delete file from server
            var filePath = Path.Combine(_hostEnvironment.WebRootPath, document.FilePath.TrimStart('/'));
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            // ✅ Add Interaction for student
            var interaction = new Interaction
            {
                TutorId = userId,
                StudentId = document.StudentId,
                Type = $"just deleted document {document.DocumentName}",
                Timestamp = DateTime.UtcNow
            };

            _context.Interactions.Add(interaction);

            // Remove from database
            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();


            return RedirectToAction("Document");
        }

        return Unauthorized();
    }

}