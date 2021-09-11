using System;
using System.Linq;
using System.Collections.Generic;
using DWWebApp.Core;

namespace DWWebApp.Data
{
    public interface IDeveloperData
    {
        IEnumerable<Developer> GetDevelopers();

        Developer GetById(int id);
    }

    public class InMemoryDeveloperData : IDeveloperData
    {
        readonly List<Developer> developers;

        public InMemoryDeveloperData()
        {
            developers = new List<Developer>
            {
                new Developer {
                    devId = 0,
                    devUsername = "Dzzape",
                    devYears = 21 ,
                    devAbout = "  This post is all about Tstatuses as your photo captions, Instagram captions for selfies or profile pictures."},
                new Developer
                {
                    devId = 1,
                    devUsername = "Mape",
                    devYears = 22 ,
                    devAbout = " Abuto test tintiri mintiri"
                }                               
            };
        }

        public Developer GetById(int id)
        {
            return developers.SingleOrDefault(i => i.devId == id);
        }

        public IEnumerable<Developer> GetDevelopers()
        {
            return developers;
        }
    }
}
