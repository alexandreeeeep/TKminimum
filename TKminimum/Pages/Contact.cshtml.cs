using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace TKminimum.Pages
{
	public class Contact : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public Contact(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}