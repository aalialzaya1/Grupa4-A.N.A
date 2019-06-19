using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class VozilaPrijavljenController : Controller
    {
        public IActionResult VozilaPrijavljen()
        {
            return View();
        }
        public IActionResult OdjavaOnClick()
        {
            return View("../Vozila/Vozila");
        }
        public IActionResult PretragaOnClick()
        {
            return View("../PretragaPrijavljen/PretragaPrijavljen");
        }
        public IActionResult KontakOnClick()
        {
            return View("../KontaktPrijavljen/KontaktPrijavljen");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../UsloviPrijavljen/UsloviPrijavljen");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
        public IActionResult RezervisiOnClick()
        {
            return View("../RezervacijaPrijavljen/RezervacijaPrijavljen");
        }
    }
}
