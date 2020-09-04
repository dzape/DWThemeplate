using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DWThemeplate.Data;
using DWThemeplate.Core;

namespace DWThemeplate.Pages.Projects
{
    public class detailsModel : PageModel
    {
        private readonly IProjectsData projectData;
        public Project Project { get; set; }

        public detailsModel(IProjectsData projectData)
        {
            this.projectData = projectData;
        }

        public IActionResult OnGet(int projectId)
        {
            Project = projectData.GetById(projectId);

            if (Project == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
