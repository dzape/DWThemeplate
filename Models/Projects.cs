using System;

namespace DWThemeplate.Models
{ 
    public class Project
    {
        public String ProjectName { get; set; }
        public String LinkToGit { get; set; }
        public String Tehnologys { get; set; } // array []
        public String About { get; set; }
        public String[] ListOfProjectsFromGit { get; set; }
    }
}
