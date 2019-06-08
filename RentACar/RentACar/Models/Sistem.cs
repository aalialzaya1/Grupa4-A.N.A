using System;
namespace RentACar.Models
{
    public class Sistem
    {
        private Sistem instance;

        public Sistem()
        {
        }

        public Sistem Instance { get => instance; set => instance = value; }

        public static Boolean validacijaPrijave(String korisnickoIme, String sifra) {
            return true;
        }

        public static Boolean validacijaRegistracije()
        {
            return true;
        }

        public static Boolean validacijaRezervacije(String korisnickoIme, String sifra)
        {
            return true;
        }
    }
}
