namespace COMP1640.ViewModels;

public class DocumentViewModel
{
    public int Id { get; set; }
    public string Author { get; set; }
    public string DocumentName { get; set; }
    public string FilePath { get; set; }
    public DateTime DateUploaded { get; set; }
    public List<CommentViewModel> Comments { get; set; } = new List<CommentViewModel>();
}
