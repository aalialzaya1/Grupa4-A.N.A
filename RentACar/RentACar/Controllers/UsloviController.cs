using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class UsloviController : Controller
    {
        public IActionResult Uslovi()
        {
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
        public IActionResult KontakOnClick()
        {
            return View("../Kontakt/Kontakt");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../Pocetna/Pocetna");
        }
    }
}
