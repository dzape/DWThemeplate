using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using DWThemeplate.Core;
using DWThemeplate.Data;

namespace DWThemeplate.Main.Pages.Projects
{
    public class ProjectModel : PageModel
    {

        private readonly IConfiguration config;
        private readonly IProjectData projectData;

        public IEnumerable <Project> Projects{ get; set; }
        public string Message { get; set; } 

        public ProjectModel(    IConfiguration config,
                                IProjectData projectData)
        {
            this.config = config;
            this.projectData = projectData;
        }                                

        public void OnGet(string searchTerm)
        {
            Projects = projectData.GetProjects(searchTerm);

        }
    }
}