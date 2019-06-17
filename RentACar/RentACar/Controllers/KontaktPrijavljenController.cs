using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class KontaktPrijavljenController : Controller
    {
        public IActionResult KontaktPrijavljen()
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
            return View("../PretragaPrijavljen/PretragaPrijavljen");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../UsloviPrijavljen/UsloviPrijavljen");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
    }
}
