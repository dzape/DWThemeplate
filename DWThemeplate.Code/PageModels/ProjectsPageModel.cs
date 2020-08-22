using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DWThemeplate.Service;

namespace DWThemeplate.PageModels
{
    public class GetProjecModel : PageModel
    {
        private readonly IProjectService _projectService;

        public GetProjecModel(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public JsonResult OnGet()
        {
            return new JsonResult(_projectService.ReadAll());
        }
    }
}