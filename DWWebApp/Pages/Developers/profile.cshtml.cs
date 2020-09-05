using Microsoft.AspNetCore.Mvc.RazorPages;
using DWWebApp.Core;
using DWWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DWWebApp.Pages.Developers
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
