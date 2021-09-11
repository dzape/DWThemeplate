using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace DWWebApp.Core
{
    public class Project
    {
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if(value > 99 && value.ToString().Length <= 999)
                {
                    _id = value;
                }
            }
        }

        private string _projectname;
        public string ProjectsName
        {
            get
            {
                return _projectname;
            }
            set
            {
                if (value.Length <= 100)
                    _projectname = value;
            }
        }

        public List<LanguagesType> Language { get; set; }
        public string GitUrl { get; set; }
        public string About { get; set; }
    }
}