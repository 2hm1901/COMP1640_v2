using COMP1640.Models;

namespace COMP1640.ViewModels;

public class UploadDocumentViewModel
{
    public string DocumentName { get; set; }
    public IFormFile File { get; set; }
    public List<ApplicationUser> Students { get; set; }
}
