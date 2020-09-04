using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using DWThemeplate.Core;
using DWThemeplate.Data;

namespace DWThemeplate.Pages.Projects
{
    public class listModel : PageModel
    {

        private readonly IConfiguration config;
        private readonly IProjectsData ProjectsData;

        public IEnumerable<Project> Projects { get; set; }
        public string Message { get; set; }

        public listModel(IConfiguration config,
                         IProjectsData ProjectsData)
        {
            this.config = config;
            this.ProjectsData = ProjectsData;
        }

        public void OnGet(string searchTerm)
        {
            Projects = ProjectsData.GetProjectss(searchTerm);
        }
    }
}
