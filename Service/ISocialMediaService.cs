using System.Collections.Generic;

namespace DWThemeplate.Service
{
    public interface ISocialMediaService
    {
        List<Models.SocialMedia> ReadAll();
    }
}
