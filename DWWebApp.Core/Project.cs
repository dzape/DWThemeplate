using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace DWWebApp.Core
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectsName { get; set; }
        public List<LanguagesType> Language { get; set; }
        public string GitUrl { get; set; }
        public string About { get; set; }
    }
}