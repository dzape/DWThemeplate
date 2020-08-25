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
    }

    public class InMemoryProjectData : IProjectData
    {
        readonly List<Project> projects;

        public InMemoryProjectData()
        {
            projects = new List<Project>
            {
                new Project { Id = 1 , ProjectName = "Cipiripi " , Tehnologys = " C++ , Java " , About = " This project is fushhhhh"},
                new Project { Id = 2 , ProjectName = "DWThemeplate " , Tehnologys = " C++ , Java " , About = " This project is fushhhhh"}

            };
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