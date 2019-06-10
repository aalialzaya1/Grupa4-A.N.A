using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class KontaktController : Controller
    {
        public IActionResult Kontakt()
        {
            ViewData["Message"] = "Informacije: ";

            return View();
        }
        public IActionResult PrijavaOnClick()
        {
            return View("../Prijava/Prijava");
        }

        public IActionResult VozilaOnClick()
        {
            return View("../Vozila/Vozila");
        }

        public IActionResult PretragaOnClick()
        {
            return View("../Pretraga/Pretraga");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../Uslovi/Uslovi");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../Pocetna/Pocetna");
        }
    }
}
