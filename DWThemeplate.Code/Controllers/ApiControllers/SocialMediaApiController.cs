using Microsoft.AspNetCore.Mvc;
using DWThemeplate.Models;
using DWThemeplate.Service;
using System.Collections.Generic;

namespace DWThemeplate.Controllers.ApiControllers
{
    [Produces("application/json")]
    [Route("api/SocialMedia")]
    public class SocialMediaApiController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaApiController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        [HttpGet]
        public IEnumerable<SocialMedia> GetMedias()
        {
            return _socialMediaService.ReadAll();
        }

    }
}