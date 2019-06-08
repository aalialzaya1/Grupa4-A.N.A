using System;
namespace RentACar.Models
{
    public class Racun
    {
        private int id;
        private int idMenadzera;
        private int sifraRacuna;
        private double iznos;
        private Rezervacija rezervacija;

        public Racun()
        {
        }

        public Racun(int id, int idMenadzera, int sifraRacuna, double iznos, Rezervacija rezervacija)
        {
            this.Id = id;
            this.IdMenadzera = idMenadzera;
            this.SifraRacuna = sifraRacuna;
            this.Iznos = iznos;
            this.Rezervacija = rezervacija;
        }

        public int Id { get => id; set => id = value; }
        public int IdMenadzera { get => idMenadzera; set => idMenadzera = value; }
        public int SifraRacuna { get => sifraRacuna; set => sifraRacuna = value; }
        public double Iznos { get => iznos; set => iznos = value; }
        public Rezervacija Rezervacija { get => rezervacija; set => rezervacija = value; }
    }
}
