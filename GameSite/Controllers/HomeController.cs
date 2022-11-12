using System.Diagnostics;
using GameSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameSite.Controllers;

public class HomeController : Controller {

	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger) => _logger = logger;

	public IActionResult Index() => View();

	public IActionResult About() => View();

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error() =>
		View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});

}