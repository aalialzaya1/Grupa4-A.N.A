using System;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class dodajVoziloController : Controller
    {
        private static DatabaseContext db = DatabaseContext.getInstance();
        public IActionResult dodajVozilo()
        {
            return View();
        }

        public IActionResult DodavanjeVozilaOnClick(string naziv, string grad, string cijena, string marka, string benzin, string brSjedista, string tip)
        {
            if (naziv != null && grad != null && cijena != null && marka != null && benzin != null && brSjedista != null && tip != null)
            {
                String tipGoriva = benzin.ToUpper();
                Vozilo.VrstaGoriva vg = Vozilo.VrstaGoriva.BENZIN;
                if (tipGoriva == "BENZIN") vg = Vozilo.VrstaGoriva.BENZIN;
                if (tipGoriva == "DIZEL") vg = Vozilo.VrstaGoriva.DIZEL;
                String tipTransimisije = tip.ToUpper();
                Vozilo.Transmisija t = Vozilo.Transmisija.AUTOMATIK;
                if (tipTransimisije == "AUTOMATIK") t = Vozilo.Transmisija.AUTOMATIK;
                if (tipTransimisije == "POLUAUTOMATIK") t = Vozilo.Transmisija.POLUAUTOMATIK;
                if (tipTransimisije == "MANUAL") t = Vozilo.Transmisija.MANUAL;
                db.Vozila.Add(new Vozilo
                {
                    Naziv = naziv,
                    Marka = marka,
                    BrojVrata = Int32.Parse(brSjedista),
                    BrojSjedista = Int32.Parse(brSjedista),
                    VrstaGoriva1 = vg,
                    Dostupnost = true,
                    Fotografija = 4,
                    OsnovnaCijena = Double.Parse(cijena),
                    Transmisija1 = t
                });
                db.SaveChanges();
                return View("../VozilaUposlenik/VozilaUposlenik");
            }
            else return View("../NotifikacijaDodaj/NotifikacijaDodaj");
        }
    }
}
