using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PocetnaController : Controller
    {
        public IActionResult Pocetna()
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
            return View("../Kontak/Kontak");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../Uslovi/Uslovi");
        }
    }
}
