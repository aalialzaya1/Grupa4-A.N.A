using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class PrijavaController : Controller
    {
        public static String prijavljen = "";
        private static DatabaseContext db = DatabaseContext.getInstance();
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
                var trenutniEmailovi = db.Osobe.Where((Osoba osoba) => osoba.Email.Equals(email));
              

                    if (trenutniEmailovi.Count() != 0)
                    {
                        Osoba osoba = db.premEMailu(email);
                        if (osoba.Sifra.Equals(sifra))
                        {
                            prijavljen = email;
                            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
                        }
                        else return View("../NotifikacijaPogresnaSifra/NotifikacijaPogresnaSifra");
                    }
                    else
                    {
                        return View("../NotifikacijaNemaEmaila/NotifikacijaNemaEmaila");
                    }
            }
            else return View("../NotifikacijaPrijave/NotifikacijaPrijave");
            //return View("../Prijava/Prijava");
        }
    }
}
