using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PrijavaController : Controller
    {
        public IActionResult Prijava()
        {
            return View();
        }
        public IActionResult RegistracijaOnClick()
        {
            return View("../Registracija/Registracija");
        }

        public IActionResult PrijavaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
        [HttpPost]
        public IActionResult Validacija(string email, string sifra)
        {
            if (email != null && sifra != null)
            {
                return View("../PocetnaPrijavljen/PocetnaPrijavljen");
            }
            return View("../Prijava/Prijava");
        }
    }
}
