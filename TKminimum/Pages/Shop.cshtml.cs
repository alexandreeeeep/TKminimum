using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TKminimum.Pages
{
    public class Products : PageModel
    {
        private readonly ILogger<Products> _logger;

        public Products(ILogger<Products> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}