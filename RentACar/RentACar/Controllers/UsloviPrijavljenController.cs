using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class UsloviPrijavljenController : Controller
    {
        public IActionResult UsloviPrijavljen()
        {
            return View();
        }
        public IActionResult PrijavaOnClick()
        {
            return View("../Pocetna/Pocetna");
        }

        public IActionResult VozilaOnClick()
        {
            return View("../VozilaPrijavljen/VozilaPrijavljen");
        }

        public IActionResult PretragaOnClick()
        {
            return View("../PretragaPrijavljen/PretragaPrijavljen");
        }
        public IActionResult KontakOnClick()
        {
            return View("../KontaktPrijavljen/KontaktPrijavljen");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
        public IActionResult OdjavaOnClick()
        {
            return View("../Uslovi/Uslovi");
        }
    }
}
