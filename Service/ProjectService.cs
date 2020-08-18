using System;
using DWThemeplate.Models;
using System.Collections.Generic;

namespace DWThemeplate.Service
{
    public class ProjectService : IProjectService
    {
        public List<Project> ReadAll()
        {
            List<Project> projects = new List<Project>
            {
                new Project{ProjectName = "Test1",LinkToGit = "LinkTOGT", About = "txt"},
            };
            return projects;
        }
    }
}