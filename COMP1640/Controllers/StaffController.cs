using COMP1640.Data;
using COMP1640.Models;
using COMP1640.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMP1640.Controllers;

[Authorize(Roles = "Staff")]
public class StaffController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public StaffController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Student(string searchQuery = null, bool? withoutTutor = false, bool? noInteraction7d = false)
    {
        // Fetch student IDs in memory
        var studentUsers = await _userManager.GetUsersInRoleAsync("Student");
        var studentIds = studentUsers.Select(u => u.Id).ToList();

        // Query the database with the student IDs
        var studentsQuery = _context.Users
        .Include(s => s.Tutor)
        .Where(u => studentIds.Contains(u.Id))
        .Select(s => new
        {
            Student = s,
            MessageCount = _context.Messages.Count(m => m.SenderId == s.Id || m.ReceiverId == s.Id) // ✅ Fetch messages count
        })
        .AsQueryable();

        // Apply filters
        if (!string.IsNullOrEmpty(searchQuery))
        {
            searchQuery = searchQuery.ToLower();
            studentsQuery = studentsQuery.Where(s => s.Student.FullName.ToLower().Contains(searchQuery));
        }

        if (withoutTutor == true)
        {
            studentsQuery = studentsQuery.Where(s => s.Student.TutorId == null);
        }

        if (noInteraction7d == true)
        {
            studentsQuery = studentsQuery.Where(s => s.MessageCount == 0);
        }

        // Fetch teachers
        var teacherList = await _userManager.GetUsersInRoleAsync("Teacher");
        var availableTeachers = teacherList.Select(t => new TeacherViewModel
        {
            Id = t.Id,
            FullName = t.FullName
        }).ToList();

        // Materialize the query
        var students = await studentsQuery.Select(s => new StudentViewModel
        {
            Id = s.Student.Id,
            FullName = s.Student.FullName,
            Email = s.Student.Email,
            TutorName = s.Student.Tutor != null ? s.Student.Tutor.FullName : "No Tutor",
            TutorId = s.Student.TutorId,
            MessageCount = s.MessageCount, // ✅ Use dynamically fetched message count
            AvailableTeachers = availableTeachers
        }).ToListAsync();

        ViewBag.SearchQuery = searchQuery;
        ViewBag.WithoutTutor = withoutTutor;
        ViewBag.NoInteraction7d = noInteraction7d;

        return View(students);
    }

    [HttpPost]
    public async Task<IActionResult> AssignTutor(string studentId, string tutorId)
    {
        var student = await _context.Users.FindAsync(studentId);
        if (student != null)
        {
            student.TutorId = string.IsNullOrEmpty(tutorId) ? null : tutorId;
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Student));
    }

    public async Task<IActionResult> Teacher(string searchQuery = null)
    {
        var teacherUsers = await _userManager.GetUsersInRoleAsync("Teacher");
        var teacherIds = teacherUsers.Select(u => u.Id).ToList();

        var teachersQuery = _context.Users
        .Where(u => teacherIds.Contains(u.Id))
        .Select(t => new
        {
            Teacher = t,
            StudentCount = _context.Users.Count(s => s.TutorId == t.Id), // ✅ Count students assigned to the teacher
            MessageCount = _context.Messages.Count(m => m.SenderId == t.Id || m.ReceiverId == t.Id) // ✅ Count messages related to the teacher
        })
        .AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            searchQuery = searchQuery.ToLower();
            teachersQuery = teachersQuery.Where(t => t.Teacher.FullName.ToLower().Contains(searchQuery) ||
                                                     t.Teacher.Email.ToLower().Contains(searchQuery));
        }

        var teachers = await teachersQuery.Select(t => new TeacherViewModel
        {
            Id = t.Teacher.Id,
            FullName = t.Teacher.FullName,
            Email = t.Teacher.Email,
            StudentCount = t.StudentCount, // ✅ Use dynamically calculated student count
            MessageCount = t.MessageCount  // ✅ Use dynamically calculated message count
        }).ToListAsync();

        ViewBag.SearchQuery = searchQuery;
        return View(teachers);
    }

    public async Task<IActionResult> AssignStudents(string teacherId)
    {
        var teacher = await _context.Users.FindAsync(teacherId);
        if (teacher == null)
        {
            return NotFound();
        }

        var studentList = await _userManager.GetUsersInRoleAsync("Student");
        var currentStudents = await _context.Users
            .Where(s => s.TutorId == teacherId)
            .Select(s => s.Id)
            .ToListAsync();

        var viewModel = new TeacherViewModel
        {
            Id = teacher.Id,
            FullName = teacher.FullName,
            AvailableStudents = studentList.Select(s => new StudentViewModel
            {
                Id = s.Id,
                FullName = s.FullName,
                IsSelected = currentStudents.Contains(s.Id)
            }).ToList()
        };

        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AssignStudents(string teacherId, List<string> studentIds)
    {
        var teacher = await _context.Users.FindAsync(teacherId);
        if (teacher != null)
        {
            // Update students to assign them to this teacher
            var studentsToUpdate = await _context.Users
                .Where(s => studentIds.Contains(s.Id))
                .ToListAsync();

            foreach (var student in studentsToUpdate)
            {
                student.TutorId = teacherId;
            }

            // Remove this teacher from students not in the selected list
            var studentsToRemove = await _context.Users
                .Where(s => s.TutorId == teacherId && !studentIds.Contains(s.Id))
                .ToListAsync();

            foreach (var student in studentsToRemove)
            {
                student.TutorId = null;
            }

            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Teacher));
    }
}
