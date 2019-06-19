using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaPrijaveController : Controller
    {
        public IActionResult NotifikacijaPrijave()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../Prijava/Prijava");
        }
    }
}

