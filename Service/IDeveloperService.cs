using System.Collections.Generic;

namespace DWThemeplate.Service
{
    public interface IDeveloperService
    {
        List<Models.Developer> ReadAll();
    }
}