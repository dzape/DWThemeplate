using System;
using System.Linq;
using System.Collections.Generic;
using DWThemeplate.Core;

namespace DWThemeplate.Data
{
    public interface IProjectData
    {
        IEnumerable <Project> GetProjects(string name);
       
    }

    public class InMemoryProjectData : IProjectData
    {
        readonly List<Project> projects;

        public InMemoryProjectData()
        {
            projects = new List<Project>
            {
                new Project { ProjectName = "Cipiripi " , Tehnologys = " C++ , Java " , About = " This project is fushhhhh"},
                new Project { ProjectName = "DWThemeplate " , Tehnologys = " C++ , Java " , About = " This project is fushhhhh"}

            };
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