namespace DWWebApp.Pages
{
    using DWWebApp.Data;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        InMemoryDeveloperData devData = new InMemoryDeveloperData();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

    }
}
