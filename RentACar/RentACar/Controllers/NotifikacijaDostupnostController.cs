using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaDostupnostController : Controller
    {
        public IActionResult NotifikacijaDostupnost()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../VozilaPrijavljen/VozilaPrijavljen");
        }
    }
}
