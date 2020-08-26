using System.ComponentModel;

namespace DWThemeplate.Core
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public LanguagesType Language { get; set; }
        public string About { get; set; }
    }
}