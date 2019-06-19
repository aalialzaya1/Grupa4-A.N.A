using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class RegistracijaController : Controller
    {
        private static DatabaseContext db = DatabaseContext.getInstance();

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
                var trenutnaOsoba = db.Osobe.Where((Osoba osoba) => osoba.Email.Equals(email));
                if (trenutnaOsoba.Count() != 0) {
                    return View("../NotifikacijaRegistracije/NotifikacijaRegistracije");
                }
                else
                {
                    String[] datum = datumRodjenja.Split("/");
                    db.Osobe.Add(new Klijent
                    {
                        Ime = ime + " " + prezime,
                        DatumRodjenja = new DateTime(Int32.Parse(datum[2]), Int32.Parse(datum[1]), Int32.Parse(datum[0])),
                        Email = email,
                        BrojTelefona = "0",
                        KorisnickoIme = email,
                        Sifra = sifra
                    });
                    db.SaveChanges();
                    return View("../PocetnaPrijavljen/PocetnaPrijavljen");
                }
            }
            else
            {
                return View("../NotifikacijaRegistracije/NotifikacijaRegistracije");
            }
            //return View("../Registracija/Registracija");
        }
    }
}
