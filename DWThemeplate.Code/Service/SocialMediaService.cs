using DWThemeplate.Models;
using System.Collections.Generic;

namespace DWThemeplate.Service
{
    public class SocialMediaService : ISocialMediaService
    {
        public List<SocialMedia> ReadAll()
        {
            List<SocialMedia> socialMedias = new List<SocialMedia>
            {
                new SocialMedia{Mail = "bbogdanov@mail.com",GitHub = " momak ",LinkedIn = "bb" , Instagram = "tojsum"}
            };
            return socialMedias;
        }
    }
}