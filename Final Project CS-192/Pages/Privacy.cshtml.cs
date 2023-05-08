using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_Project_CS_192.Pages
{
    public class Privacypage : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Privacypage(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}