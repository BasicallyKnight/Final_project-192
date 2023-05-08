using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_Project_CS_192.Pages
{
    public class Newpage : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Newpage(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}