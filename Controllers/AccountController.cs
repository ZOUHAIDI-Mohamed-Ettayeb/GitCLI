﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAtelier2.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
