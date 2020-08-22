using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DWThemeplate.Main.Pages.Projects
{
    public class ProjectModel : PageModel
    {
        public string Message { get; set; } 

        public void OnGet()
        {
            Message = "Test";
        }
    }
}