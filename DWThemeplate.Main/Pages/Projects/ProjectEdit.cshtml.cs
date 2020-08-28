using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using DWThemeplate.Data;
using DWThemeplate.Core;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace DWThemeplate.Main.Pages.Projects
{
    //[Authorize] //(Roles = "Administrator") // claim based autho (user id ... )
    public class ProjectEditModel : PageModel
    {
        private readonly IProjectData projectData;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Project Project { get; set; }
        public IEnumerable<SelectListItem> Language { get; set; }

        public ProjectEditModel(IProjectData projectData,
                                IHtmlHelper htmlHelper)
        {
            this.projectData = projectData;
            this.htmlHelper = htmlHelper;
        } 

        //[AllowAnonymous]
        public IActionResult OnGet(int projectId)
        {
            Language = htmlHelper.GetEnumSelectList<LanguagesType>();
            Project = projectData.GetById(projectId);
            if(Project == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Language = htmlHelper.GetEnumSelectList<LanguagesType>();
                return Page();
            }
            if(Project.Id > 0)
            {
                projectData.Update(Project);
            }
            else
            {
                //projectData.Add(Project);
            }
            
            projectData.Commit();
            return RedirectToPage("./ProjectDetails", new { });

        }
    }
}