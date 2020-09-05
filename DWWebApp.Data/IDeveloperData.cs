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
                                devUsername = "Dzzape",
                                devYears = 21 ,
        /* Copy and paste :)*/  devAbout = "  This post is all about to describe yourself in short words as who you are! Yes, you may define them as About Me Status, Even you may call them Status On Myself. However you treat these About Me Statuses, all of these short status on myself will help you to update your about me, intro or bio section of your social media profile also will help you to share some funny status about yourself on Facebook, Whatsapp or Instagram! Just Take a look; here we gather lots of short, funny and motivational status on myself which are too cute to use as about me status for any kind of social media profile or show your thoughts about yourself! Also, you may use these short about me statuses as your photo captions, Instagram captions for selfies or profile pictures."},

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
