using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using DWThemeplate.Core;
using DWThemeplate.Data;
using Microsoft.AspNetCore.Mvc;

namespace DWThemeplate.Main.Pages.Projects
{
    public class ProjectDetailsModel : PageModel
    {
        public Project Project { get; set; }

        private readonly IProjectData projectData;

        public ProjectDetailsModel (IProjectData projectData)
        {
            this.projectData = projectData;
        }
        public IActionResult OnGet(int projectId)
        {
            Project = projectData.GetById(projectId);
            if(Project == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}