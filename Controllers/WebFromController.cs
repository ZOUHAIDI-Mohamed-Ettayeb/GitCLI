﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAtelier2.Controllers
{
	public class WebFromController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult WebForm2()
		{
			return View();
		}
	}
}
