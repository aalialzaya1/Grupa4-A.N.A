using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PocetnaPrijavljenController : Controller
    {
        public IActionResult PocetnaPrijavljen()
        {
            return View();
        }
        public IActionResult OdjavaOnClick()
        {
            return View("../Pocetna/Pocetna");
        }

        public IActionResult VozilaOnClick()
        {
            return View("../VozilaPrijavljen/VozilaPrijavljen");
        }

        public IActionResult PretragaOnClick()
        {
            return View("../Pretraga/Pretraga");
        }
        public IActionResult KontakOnClick()
        {
            return View("../KontaktPrijavljen/KontaktPrijavljen");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../UsloviPrijavljen/UsloviPrijavljen");
        }
    }
}
