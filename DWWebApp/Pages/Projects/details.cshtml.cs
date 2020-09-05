using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DWWebApp.Data;
using DWWebApp.Core;

namespace DWWebApp.Pages.Projects
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
