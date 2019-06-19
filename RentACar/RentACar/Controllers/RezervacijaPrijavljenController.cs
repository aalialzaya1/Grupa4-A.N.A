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
                if ((lokacijaVracanja != "Sarajevo" && lokacijaVracanja != "Zenica" && lokacijaVracanja != "Tuzla") || (lokacijaPreuzimanja != "Sarajevo" && lokacijaPreuzimanja != "Zenica" && lokacijaPreuzimanja != "Tuzla")) {
                    return View("../NotifikacijaNeispravanGrad/NotifikacijaNeispravanGrad");
                }
                else {
                    if (VozilaPrijavljenController.auto != null)
                    {
                        var kliknutoVozilo = db.Vozila.Where((Vozilo v) => v.Naziv.Equals(VozilaPrijavljenController.auto));
                        if (kliknutoVozilo.Count() != 0)
                        {
                            Vozilo voziloR = (Vozilo)kliknutoVozilo.First();
                            voziloR.Dostupnost = false;
                            db.Vozila.Update(voziloR);
                            db.SaveChanges();
                            //return View("../NotifikacijaUspjesnoRezervisano/NotifikacijaUspjesnoRezervisano");
                            String[] datumPreuzimanja = datumOD.Split("/");
                            String[] datumVracanja = datumDO.Split("/");
                            DateTime datumPreuzimanjaOd = new DateTime(Int32.Parse(datumPreuzimanja[2]), Int32.Parse(datumPreuzimanja[1]), Int32.Parse(datumPreuzimanja[0]));
                            DateTime datumVracanjaDo = new DateTime(Int32.Parse(datumVracanja[2]), Int32.Parse(datumVracanja[1]), Int32.Parse(datumVracanja[0]));
                            int daniIzmedju = ((TimeSpan)(datumVracanjaDo - datumPreuzimanjaOd)).Days;
                            var osobe = db.Osobe.Where((Osoba osoba) => osoba.Email.Equals(PrijavaController.prijavljen));
                            Osoba osobaKojaRezervise = (Osoba)osobe.First();
                            //DatumRodjenja = new DateTime(Int32.Parse(datum[2]), Int32.Parse(datum[1]), Int32.Parse(datum[0]))
                            var gradoviPreuzimanja = db.Gradovi.Where((Grad grad) => grad.Naziv.Equals(lokacijaPreuzimanja));
                            var gradoviVracanja = db.Gradovi.Where((Grad grad) => grad.Naziv.Equals(lokacijaVracanja));
                            Grad gradPreuzimanja = gradoviPreuzimanja.First();
                            Grad gradVracanja = gradoviVracanja.First();
                            db.Rezervacije.Add(new Rezervacija
                            {
                                BrojDana = daniIzmedju,
                                KlijentId = osobaKojaRezervise.Id,
                                VoziloId = voziloR.id,
                                NacinPlacanja1 = (int)Rezervacija.NacinPlacanja.SADA,
                                GradPreuzimanjaId = gradPreuzimanja.Id,
                                GradVracanjaId = gradVracanja.Id,
                                DatumPreuzimanja = datumPreuzimanjaOd,
                                DatumVracanja = datumVracanjaDo

                            });
                            db.SaveChanges();
                            return View("..//NotifikacijaUspjesnoRezervisano/NotifikacijaUspjesnoRezervisano");
                        }

                    }
                }
            }
            return View("../NotifikacijaRezervacije2/NotifikacijaRezervacije2");
            //return View("../Registracija/Registracija");
        }
    }
}
