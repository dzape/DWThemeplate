using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DWThemeplate.Service;

namespace DWThemeplate.PageModels
{
    public class GetDeveloperModel : PageModel
    {
        private readonly IDeveloperService _developerService;

        public GetDeveloperModel(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        public JsonResult OnGet()
        {
            return new JsonResult(_developerService.ReadAll());        }
        }
}