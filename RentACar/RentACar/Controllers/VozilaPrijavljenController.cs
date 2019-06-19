using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class VozilaPrijavljenController : Controller
    {
        private static DatabaseContext db = DatabaseContext.getInstance();
        public IActionResult VozilaPrijavljen()
        {
            return View();
        }
        public IActionResult OdjavaOnClick()
        {
            return View("../Vozila/Vozila");
        }
        public IActionResult PretragaOnClick()
        {
            return View("../PretragaPrijavljen/PretragaPrijavljen");
        }
        public IActionResult KontakOnClick()
        {
            return View("../KontaktPrijavljen/KontaktPrijavljen");
        }
        public IActionResult UsloviOnClick()
        {
            return View("../UsloviPrijavljen/UsloviPrijavljen");
        }
        public IActionResult PocetnaOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
        public IActionResult RezervisiOnClick(string vozilo)
        {
            if(vozilo != null)
            {
                var kliknutoVozilo = db.Vozila.Where((Vozilo v) => v.Naziv.Equals(vozilo));
                if(kliknutoVozilo.Count() != 0)
                {
                    Vozilo voziloR = (Vozilo)kliknutoVozilo.First();                     if (voziloR.Dostupnost == false)                     {                         return View("../NotifikacijaRezervacije/NotifikacijaRezervacije");                     }                     else                     {                         voziloR.Dostupnost = false;                         db.Vozila.Update(voziloR);                         db.SaveChanges();
                        return View("../RezervacijaPrijavljen/RezervacijaPrijavljen");
                    }
                }                     /*db.Vozila.Add(new Vozilo                     {                         Naziv = vozilo,                         Marka = "Buggati",                         BrojVrata = 3,                         BrojSjedista = 5,                         VrstaGoriva1 = Vozilo.VrstaGoriva.BENZIN,                         Dostupnost = false,                         Fotografija = 3,                         OsnovnaCijena = 500,                         Transmisija1 = Vozilo.Transmisija.AUTOMATIK                                              });                     db.SaveChanges();*/
            }
            return View("../RezervacijaPrijavljen/RezervacijaPrijavljen");
        }
    }
}
