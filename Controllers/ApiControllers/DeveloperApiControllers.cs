using Microsoft.AspNetCore.Mvc;
using DWThemeplate.Models;
using DWThemeplate.Service;
using System.Collections.Generic;

namespace DWThemeplate.Controllers.ApiControllers
{
    [Produces("application/json")]
    [Route("api/Developer")]
    public class DeveloperApiController : Controller
    {
        private readonly IDeveloperService _developerService;

        public DeveloperApiController(IDeveloperService developerService)
        {
            _developerService = developerService;
        }

        //GET : api/Developer
        [HttpGet]
        public IEnumerable<Developer> GetDevelopers()
        {
            return _developerService.ReadAll();
        }
    }
}