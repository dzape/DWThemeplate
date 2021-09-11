using DWWebApp.Core;
using DWWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DWWebApp.Pages.Projects
{
    public class editModel : PageModel
    {
        private readonly IProjectsData projectData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Project Projects { get; set; }
        public IEnumerable<SelectListItem> Language { get; set; }

        public editModel(IProjectsData ProjectsData,
                                IHtmlHelper htmlHelper)
        {
            this.projectData = ProjectsData;
            this.htmlHelper = htmlHelper;
        }

        //[AllowAnonymous]
        public IActionResult OnGet(int? ProjectsId)
        {
            Language = htmlHelper.GetEnumSelectList<LanguagesType>();
            
            if(ProjectsId.HasValue)
            {
                Projects = projectData.GetById(ProjectsId.Value);
            }
            else
            {
                Projects = new Project();
            }
            if(Projects == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Language = htmlHelper.GetEnumSelectList<LanguagesType>();
                return Page();
            }
            if (Projects.Id > 0)
            {
                projectData.Update(Projects);
            }
            else
            {
                projectData.Add(Projects);
            }

            projectData.Commit();
            return RedirectToPage("./list");
        }
    }
}
