using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FilterFramework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Message", "This is the Index action on the Home controller");
        }
        public ViewResult SecondAction() => View("Message",
            "This is the SecondAction action on the Home controller");
    }


}
