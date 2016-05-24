using System;
using Microsoft.AspNet.Mvc;

namespace ThinClient.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}