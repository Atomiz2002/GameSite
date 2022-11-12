using System.Reflection.Metadata.Ecma335;
using GameSite.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace GameSite.Controllers;

public class AccountController : Controller {

	public IActionResult Login(Login model = null) {
		if (model == null) return View(new Login());

		return View(new Login());
	}

	public IActionResult Register(Register model = null) {
		if (model == null) return View(new Register());

		return View(new Register());
	}

}