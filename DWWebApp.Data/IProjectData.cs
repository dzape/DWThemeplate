using System.Linq;
using System.Collections.Generic;
using DWWebApp.Core;

namespace DWWebApp.Data
{
    public interface IProjectsData
    {
        IEnumerable<Project> GetProjectss(string name);
        Project GetById(int id);
        Project Update(Project updateProject);
        Project Add(Project newProject);
        int Commit();
    }

    public class InMemoryProjectsData : IProjectsData
    {
        readonly List<Project> projects;

        public InMemoryProjectsData()
        {
            projects = new List<Project>
            {
                new Project { Id = 1 ,
                            ProjectsName = "Cipiripi" ,
                            Language = new List<LanguagesType>{LanguagesType.Cpp,LanguagesType.Ruby} ,
                            GitUrl = "https://github.com/OdeToCode/OdeToFood",
                            About = " This Projects is fushhhhh"},

                new Project { Id = 2 ,
                            ProjectsName = "DWThemeplate" ,
                            Language = new List<LanguagesType>{LanguagesType.Cpp,LanguagesType.Ruby},
                            GitUrl = "https://github.com/OdeToCode/OdeToFood",
                            About = " This Projects is fushhhhh"},

                new Project { Id = 3 ,
                            ProjectsName = "ende-Japi" ,
                            Language = new List<LanguagesType>{LanguagesType.Python,LanguagesType.JavaScript,LanguagesType.Swift},
                            GitUrl = "https://github.com/OdeToCode/OdeToFood",
                            About = " This Projects is fushhhhh"}
            };
        }

        public Project Update(Project updateProjects)
        {
            var Projects = projects.SingleOrDefault(i => i.Id == updateProjects.Id);
            if (projects != null)
            {
                Projects.ProjectsName = updateProjects.ProjectsName;
                Projects.Language = updateProjects.Language;
                Projects.About = updateProjects.About;
            }
            return Projects;
        }
        
        public Project Add(Project newProject)
        {
            projects.Add(newProject);
            newProject.Id = projects.Max(i => i.Id) + 1;
            return newProject;
        }

        public int Commit()
        {
            return 0;
        }

        public Project GetById(int id)
        {
            return projects.SingleOrDefault(i => i.Id == id);
        }
        public IEnumerable<Project> GetProjectss(string name = null)
        {
            return from p in projects
                   where string.IsNullOrEmpty(name) || p.ProjectsName.StartsWith(name)

                   orderby p.ProjectsName
                   select p;
        }

        public void Add()
        {
            throw new System.NotImplementedException();
        }
    }
}