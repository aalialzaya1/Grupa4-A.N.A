using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class VozilaUposlenikController : Controller
    {
        private static DatabaseContext db = DatabaseContext.getInstance();
        public IActionResult VozilaUposlenik()
        {
            return View();
        }
        public IActionResult OdjavaOnClick()
        {
            return View("../Vozila/Vozila");
        }
        public IActionResult DodajVoziloOnClick()
        {
            return View("../DodajVozilo/DodajVozilo");
        }
        public IActionResult VozilaOnClick()
        {
            return View("../VozilaUposlenik/VozilaUposlenik");
        }
        public IActionResult OslobodiOnClick(string vozilo)
        {
            if (vozilo != null)
            {
                var kliknutoVozilo = db.Vozila.Where((Vozilo v) => v.Naziv.Equals(vozilo));
                if (kliknutoVozilo.Count() != 0)
                {
                    Vozilo voziloR = (Vozilo)kliknutoVozilo.First();
                    voziloR.Dostupnost = true;
                    db.Vozila.Update(voziloR);
                    db.SaveChanges();
                }
            }
            return View("../VozilaUposlenik/VozilaUposlenik");
        }
    }
}
