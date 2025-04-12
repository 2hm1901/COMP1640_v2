using System.ComponentModel.DataAnnotations.Schema;

namespace COMP1640.Models;

public class Meeting
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Deadline { get; set; }
    public string MeetingLink { get; set; } // Google Meet link
    public string? RecordLink { get; set; }
    public string TeacherId { get; set; }
    public string StudentId { get; set; }


    [ForeignKey("TeacherId")]
    public virtual ApplicationUser Teacher { get; set; }

    [ForeignKey("StudentId")]
    public virtual ApplicationUser Student { get; set; }
}
