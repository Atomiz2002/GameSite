using GameSite.Models.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameSite.Areas.Identity.Controllers;

[Area("Identity")]
public class IdentityController : Controller {

	public IActionResult Login(Login? model = null) {
		if (!ModelState.IsValid) return View(model ?? new Login());

		return RedirectToAction("Index", "Home");
	}

	public IActionResult Register(Register? model = null) {
		if (!ModelState.IsValid) return View(model ?? new Register());

		return RedirectToAction("Index", "Home");
	}

}