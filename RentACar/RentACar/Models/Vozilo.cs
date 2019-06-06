using System;
namespace RentACar.Models
{
    public class Vozilo
    {
        public enum VrstaGoriva { Benzin, Dizel };
        public enum Transmisija { Automatik, Manual, Poluautomatik }
        private String naziv;
        private String marka;
        private int brojVrata;
        private int brojSjedista;
        private VrstaGoriva vrstaGoriva;
        private bool dostupnost;
        private int fotografija;
        private double osnovnaCijena;
        private Transmisija transmisija;

        public Vozilo()
        {
        }

        public Vozilo(string naziv, string marka, int brojVrata, int brojSjedista, VrstaGoriva vrstaGoriva, bool dostupnost, int fotografija, double osnovnaCijena, Transmisija transmisija)
        {
            this.Naziv1 = naziv;
            this.marka = marka;
            this.brojVrata = brojVrata;
            this.brojSjedista = brojSjedista;
            this.vrstaGoriva = vrstaGoriva;
            this.dostupnost = dostupnost;
            this.fotografija = fotografija;
            this.osnovnaCijena = osnovnaCijena;
            this.transmisija = transmisija;
        }

        public String Naziv
        {
            get
            {
                return Naziv1;
            }
        }

        public String Marka
        {
            get
            {
                return marka;
            }
        }

        public int BrojVrata
        {
            get
            {
                return brojVrata;
            }
        }

        public int BrojSjedista
        {
            get
            {
                return brojSjedista;
            }
        }

        public VrstaGoriva VrstaGoriva2
        {
            get
            {
                return vrstaGoriva;
            }
        }

        public bool Dostupnost
        {
            get
            {
                return dostupnost;
            }
        }

        public int Fotografija
        {
            get
            {
                return fotografija;
            }
        }

        public double OsnovnaCijena
        {
            get
            {
                return osnovnaCijena;
            }
        }

        public Transmisija Transmisija3
        {
            get
            {
                return transmisija;
            }
        }

        public string Naziv1 { get => naziv; set => naziv = value; }
        public string Marka1 { get => marka; set => marka = value; }
        public int BrojVrata1 { get => brojVrata; set => brojVrata = value; }
        public int BrojSjedista1 { get => brojSjedista; set => brojSjedista = value; }
        public VrstaGoriva VrstaGoriva1 { get => vrstaGoriva; set => vrstaGoriva = value; }
        public bool Dostupnost1 { get => dostupnost; set => dostupnost = value; }
        public int Fotografija1 { get => fotografija; set => fotografija = value; }
        public double OsnovnaCijena1 { get => osnovnaCijena; set => osnovnaCijena = value; }
        public Transmisija Transmisija1 { get => transmisija; set => transmisija = value; }
    }
}
