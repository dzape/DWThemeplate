using System.Collections.Generic;

namespace DWThemeplate.Service
{
    public interface IProjectService
    {
        List<Models.Project> ReadAll();
    }
}
