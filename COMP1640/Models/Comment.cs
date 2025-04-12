using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models;

public class Comment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Content { get; set; }  // Comment text

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public string AuthorId { get; set; }  // User who wrote the comment

    [ForeignKey("AuthorId")]
    public ApplicationUser Author { get; set; }

    [Required]
    public int DocumentId { get; set; }

    [ForeignKey("DocumentId")]
    public Document Document { get; set; }
}
