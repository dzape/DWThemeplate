using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using DWThemeplate.Service;
using DWThemeplate.Models;

namespace DWThemeplate.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public JsonResult OnGet()
        {
            return new JsonResult(_socialMediaService.ReadAll());
        }

        public IActionResult SocialMediaView()
        {
            return View();
        }
    }
}