using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DWThemeplate.Service;
using DWThemeplate.Models;

namespace DWThemeplate.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        public JsonResult OnGet()
        {
            return new JsonResult(_projectService.ReadAll());
        }

        public IActionResult ProjectsView()
        {
            return View();
        }
    }
}