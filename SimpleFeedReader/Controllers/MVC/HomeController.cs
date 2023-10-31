using Microsoft.AspNetCore.Mvc;

namespace SimpleFeedReader.Controllers.MVC
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Landing()
		{
			return View();
		}

		public IActionResult generic()
		{
			return View();
		}
	}
}
