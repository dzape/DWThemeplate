using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using DWThemeplate.Data;

namespace DWThemeplate.Main.Pages.Developers
{
    public class DeveloperModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IDeveloperData developerData;

        public string  message { get; set; }

        public DeveloperModel(  IConfiguration config,
                                IDeveloperData developerData)
        {
            this.config = config;
            this.developerData = developerData;
        }

        public void OnGet()
        {
            message = "HEllo";
        }
    }
}
