using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodluyoruzOdev1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.UserClass user)
        {
            if (user.UserName == "Zeynep" && user.UserPassword == "1234")
            { return RedirectToAction("Index", "Admin"); }
            return View();
        }
    }
}
