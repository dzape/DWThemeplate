using DWThemeplate.Models;
using System.Collections.Generic;

namespace DWThemeplate.Service
{
    public class DeveloperService : IDeveloperService
    {
        public List<Developer> ReadAll()
        {
            List<Developer> developers = new List<Developer>
            {
                new Developer{FullName = " Bojan " , UserName = " momak " ,Years = 20 , About = " some txt " },
            };
            return developers;
        }
    }
}