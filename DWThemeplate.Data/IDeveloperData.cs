using System.Collections.Generic;
using DWThemeplate.Core;
using System.Linq;

namespace DWThemeplate.Data
{
    public interface IDeveloperData
    {
        IEnumrable<Developer> GetDeveloper();
    }

    public class InMemoryDeveloperDate : IDeveloperData
    {
        readonly List<Developer> developers;

        public InMemoryDeveloperDate()
        {
            developers = new List<Developer>
            {
                new Developer {UserName = "Dzzape", Years = 21 , About = " About me ....!"},
            };
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            return from r in developers
                orderby r.Years
                select r;
        }
    }
}
