using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class RezervacijaPrijavljenController : Controller
    {
        private static DatabaseContext db = DatabaseContext.getInstance();
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
                if (VozilaPrijavljenController.auto != null)
                {
                    var kliknutoVozilo = db.Vozila.Where((Vozilo v) => v.Naziv.Equals(VozilaPrijavljenController.auto));
                    if (kliknutoVozilo.Count() != 0)
                    {
                        Vozilo voziloR = (Vozilo)kliknutoVozilo.First();
                        voziloR.Dostupnost = false;
                        db.Vozila.Update(voziloR);
                        db.SaveChanges();
                        return View("../NotifikacijaUspjesnoRezervisano/NotifikacijaUspjesnoRezervisano");
                    }
                }
            }
            return View("../NotifikacijaRezervacije2/NotifikacijaRezervacije2");
            //return View("../Registracija/Registracija");
        }
    }
}
