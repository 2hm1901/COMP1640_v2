using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models;

public class Document
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string DocumentName { get; set; }  // Name of the document

    [Required]
    public string FilePath { get; set; }  // Public URL to access the file

    [Required]
    public string StudentId { get; set; }  // The student who uploaded

    [ForeignKey("StudentId")]
    public ApplicationUser Student { get; set; }  // Link to the student

    public string? TutorId { get; set; }  // The tutor (teacher) of this student

    [ForeignKey("TutorId")]
    public ApplicationUser? Tutor { get; set; }  // Link to the teacher

    public DateTime DateUploaded { get; set; } = DateTime.UtcNow;

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
