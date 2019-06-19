using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class RezervacijaPrijavljenController : Controller
    {
        public IActionResult RezervacijaPrijavljen()
        {
            return View();
        }

        public IActionResult RezervisiOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
        [HttpPost]
        public IActionResult Validacija(string lokacijaPreuzimanja, string lokacijaVracanja, string datumOD, string datumDO, string imeIPrezime, string datumRodjenja, string brojTelefona)
        {
            if (lokacijaVracanja != null && lokacijaPreuzimanja != null && datumDO != null && datumOD != null && imeIPrezime != null && datumRodjenja != null && brojTelefona != null)
            {
                return View("../PocetnaPrijavljen/PocetnaPrijavljen");//View uspjesnorezervisanautomobil
            }
            else
            {
                return View("../NotifikacijaRezervacije2/NotifikacijaRezervacije2");
            }
            //return View("../Registracija/Registracija");
        }
    }
}
