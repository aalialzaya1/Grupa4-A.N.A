using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class VozilaController : Controller
    {
        public IActionResult Vozila()
        {
            return View();
        }
        public IActionResult PrijavaOnClick()
        {
            return View("../Prijava/Prijava");
        }
        public IActionResult PretragaOnClick()
        {
            return View("../Pretraga/Pretraga");
        }
        public IActionResult KontakOnClick()
        {
            return View("../Kontakt/Kontakt");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../Uslovi/Uslovi");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../Pocetna/Pocetna");
        }
        public IActionResult RezervisiOnClick()
        {
            return View("../NotifikacijaRezervacije/NotifikacijaRezervacije");
        }
    }
}
