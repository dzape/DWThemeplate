using System;
using System.Linq;
using System.Collections.Generic;
using DWThemeplate.Core;

namespace DWThemeplate.Data
{
    public interface IProjectData
    {
        IEnumerable <Project> GetProjects(string name);
        Project GetById(int id);
        Project Update(Project updateProject);
        int Commit();
    }

    public class InMemoryProjectData : IProjectData
    {
        readonly List<Project> projects;

        public InMemoryProjectData()
        {
            projects = new List<Project>
            {
                new Project { Id = 1 , ProjectName = "Cipiripi " , Language =  LanguagesType.Cpp , About = " This project is fushhhhh"},
                new Project { Id = 2 , ProjectName = "DWThemeplate " , Language = LanguagesType.Java, About = " This project is fushhhhh"}

            };
        }

        public Project Update(Project updateProject)
        {
            var project = projects.SingleOrDefault(i => i.Id == updateProject.Id);
            if(projects != null)
            {
                project.ProjectName = updateProject.ProjectName;
                project.Language = updateProject.Language;
                project.About = updateProject.About;
            }
            return project;
        }

        public int Commit ()
        {
            return 0;
        }

        public Project GetById(int id)
        {
            return projects.SingleOrDefault(i => i.Id == id);  
        }
        public IEnumerable <Project> GetProjects(string name = null)
        {
            return from p in projects
            where string.IsNullOrEmpty(name) || p.ProjectName.StartsWith(name)

                orderby p.ProjectName
                select p;
        }
    }
}