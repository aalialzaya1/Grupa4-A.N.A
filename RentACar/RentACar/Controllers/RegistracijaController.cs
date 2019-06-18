using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class RegistracijaController : Controller
    {
        public IActionResult Registracija()
        {
            return View();
        }
        public IActionResult PrijavaNazadOnClick()
        {
            return View("../Prijava/Prijava");
        }

        public IActionResult RegistracijaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }

        [HttpPost]
        public IActionResult Validacija(string ime, string prezime, string datumRodjenja, string email, string sifra, string potvrdaSifre)
        {
            if (ime != null && prezime != null && datumRodjenja != null && email != null && sifra != null && potvrdaSifre != null && potvrdaSifre.Equals(sifra))
            {
                return View("../PocetnaPrijavljen/PocetnaPrijavljen");
            }
            return View("../Registracija/Registracija");
        }
    }
}
