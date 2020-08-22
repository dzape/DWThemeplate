using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DWThemeplate.Service;
using DWThemeplate.Models;

namespace DWThemeplate.Controllers
{
    public class DeveloperController : Controller
    {
        private readonly IDeveloperService _developerService;

        public DeveloperController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        public JsonResult OnGet()
        {
            return new JsonResult(_developerService.ReadAll()); 
        }
       
        public IActionResult DeveloperView()
        {
            return View();
        }
    }
}