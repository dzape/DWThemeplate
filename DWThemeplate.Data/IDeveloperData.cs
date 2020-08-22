using System;
using System.Linq;
using System.Collections.Generic;
using DWThemeplate.Core;

namespace DWThemeplate.Data
{
    public interface IDeveloperData
    {
        IEnumerable <Developer> GetDevelopers();
    }

    public class InMemoryDeveloperData : IDeveloperData
    {
        readonly List<Developer> developers;

        public InMemoryDeveloperData()
        {
            developers = new List<Developer>
            {
                new Developer {UserName = "Dzzape", Years = 21 , About = " About me ....!"},
            };
        }

        public IEnumerable <Developer> GetDevelopers()
        {
            return from r in developers
                orderby r.Years
                select r;
        }
    }
}
