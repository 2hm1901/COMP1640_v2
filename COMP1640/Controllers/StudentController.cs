using COMP1640.Data;
using COMP1640.Models;
using COMP1640.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP1640.Controllers;

[Authorize(Roles = "Student")]
public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IWebHostEnvironment _hostEnvironment;

    public StudentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment)
    {
        _context = context;
        _userManager = userManager;
        _hostEnvironment = hostEnvironment;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Dashboard()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null) return RedirectToAction("Login", "Account");

        var tutor = await _context.Users
            .Where(t => t.Id == user.TutorId)
            .Select(t => new TutorMessageViewModel
            {
                TutorId = t.Id,
                TutorName = t.FullName,
                LastMessage = _context.Messages
                    .Where(m => (m.SenderId == user.Id && m.ReceiverId == t.Id) || (m.SenderId == t.Id && m.ReceiverId == user.Id))
                    .OrderByDescending(m => m.Timestamp)
                    .Select(m => m.Content)
                    .FirstOrDefault() ?? "No messages yet",
                Interactions = _context.Interactions
                .Where(i => i.TutorId == t.Id && i.StudentId == user.Id)  // Get only interactions related to this student
                .OrderByDescending(i => i.Timestamp)
                .Select(i => new InteractionViewModel
                {
                    Type = i.Type,
                    TutorName = t.FullName,
                    Timestamp = i.Timestamp.ToLocalTime()
                })
                .Take(5)
                .ToList(),
                Meetings = _context.Meetings
                .Where(m => m.TeacherId == user.TutorId && m.StudentId == user.Id) // ✅ Only show meetings where student is a participant
                .OrderBy(m => m.Deadline)
                .Select(m => new MeetingViewModel
                {
                    Id = m.Id,
                    Name = m.Name,
                    Deadline = m.Deadline.ToLocalTime(),
                    MeetingLink = m.MeetingLink,
                    RecordLink = m.RecordLink
                })
                .ToList()
            })
            .FirstOrDefaultAsync();

        return View(tutor);
    }

    public async Task<IActionResult> Document()
    {
        var userId = _userManager.GetUserId(User);

        var user = await _context.Users
            .Include(u => u.Tutor)
            .FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null)
        {
            return NotFound();
        }

        var documents = await _context.Documents
            .Where(d => d.StudentId == userId && d.TutorId == user.TutorId) // Student or their tutor can see the docs
            .Include(d => d.Comments)
            .ThenInclude(c => c.Author) // Load comments with author
            .Select(d => new DocumentViewModel
            {
                Id = d.Id,
                DocumentName = d.DocumentName,
                FilePath = d.FilePath,
                Author = d.Student.FullName,
                DateUploaded = d.DateUploaded.ToLocalTime(),
                Comments = d.Comments.OrderBy(c => c.CreatedAt)
                .Select(c => new CommentViewModel
                {
                    Author = c.Author.FullName,
                    Content = c.Content
                }).ToList()
            })
            .ToListAsync();

        return View(documents);
    }

    // Show Upload Page
    public IActionResult Upload()
    {
        return View();
    }

    // Handle Document Upload
    [HttpPost]
    public async Task<IActionResult> Upload(string DocumentName, IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            ModelState.AddModelError("", "Please select a file.");
            return View();
        }

        var userId = _userManager.GetUserId(User);
        var user = await _context.Users.Include(u => u.Tutor).FirstOrDefaultAsync(u => u.Id == userId);

        if (user == null) return Unauthorized();

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
            StudentId = userId,
            TutorId = user.TutorId,
            DateUploaded = DateTime.UtcNow
        };

        _context.Documents.Add(document);
        await _context.SaveChangesAsync();

        return RedirectToAction("Document");
    }

    [HttpPost]
    public async Task<IActionResult> DeleteDocument(int id)
    {
        var userId = _userManager.GetUserId(User);
        var document = await _context.Documents.FirstOrDefaultAsync(d => d.Id == id && d.StudentId == userId);

        if (document == null)
        {
            return NotFound();
        }

        // Delete file from server
        var filePath = Path.Combine(_hostEnvironment.WebRootPath, document.FilePath.TrimStart('/'));
        if (System.IO.File.Exists(filePath))
        {
            System.IO.File.Delete(filePath);
        }

        // Remove from database
        _context.Documents.Remove(document);
        await _context.SaveChangesAsync();

        return RedirectToAction("Document");
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

        return RedirectToAction("Document");
    }
}
