using Microsoft.AspNetCore.Mvc.RazorPages;
using DWThemeplate.Core;
using DWThemeplate.Data;
using Microsoft.AspNetCore.Mvc;

namespace DWThemeplate.Pages.Developers
{
    public class profileModel : PageModel
    {
        private readonly IDeveloperData developerData;
        public Developer Developer { get; set; }

        public profileModel(IDeveloperData developerData)
        {
            this.developerData = developerData;
        }

        public IActionResult OnGet(int devId)
        {
            Developer = developerData.GetById(devId);

            if(Developer == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}
