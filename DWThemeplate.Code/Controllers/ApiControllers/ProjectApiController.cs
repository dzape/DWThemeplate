using Microsoft.AspNetCore.Mvc;
using DWThemeplate.Models;
using DWThemeplate.Service;
using System.Collections.Generic;

namespace DWThemeplate.Controllers.ApiControllers
{
    [Produces("application/json")]
    [Route("api/Project")]
    public class ProjectApiController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectApiController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        //GET : api/Project
        [HttpGet]
        public IEnumerable<Project> GetProjects()
        {
            return _projectService.ReadAll();
        }
    }
}