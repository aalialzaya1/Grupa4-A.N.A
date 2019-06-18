using System;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public class Vozilo
    {
        public enum VrstaGoriva { 
            BENZIN, 
            DIZEL 
        };

        public enum Transmisija { 
            AUTOMATIK, 
            MANUAL, 
            POLUAUTOMATIK 
        }

        [Key]
        public int id { get; set; }
        private String naziv;
        private String marka;
        private int brojVrata;
        private int brojSjedista;
        private VrstaGoriva vrstaGoriva;
        private bool dostupnost;
        private int fotografija;
        private double osnovnaCijena;
        private Transmisija transmisija;
        private String tip;

        public Vozilo()
        {
        }

        public Vozilo(string naziv, string marka, int brojVrata, int brojSjedista, VrstaGoriva vrstaGoriva, bool dostupnost, int fotografija, double osnovnaCijena, Transmisija transmisija)
        {
            this.Naziv = naziv;
            this.marka = marka;
            this.brojVrata = brojVrata;
            this.brojSjedista = brojSjedista;
            this.vrstaGoriva = vrstaGoriva;
            this.dostupnost = dostupnost;
            this.fotografija = fotografija;
            this.osnovnaCijena = osnovnaCijena;
            this.transmisija = transmisija;
        }
        
        public string Naziv { get => naziv; set => naziv = value; }
        public string Marka { get => marka; set => marka = value; }
        public int BrojVrata { get => brojVrata; set => brojVrata = value; }
        public int BrojSjedista { get => brojSjedista; set => brojSjedista = value; }
        public VrstaGoriva VrstaGoriva1 { get => vrstaGoriva; set => vrstaGoriva = value; }
        public bool Dostupnost { get => dostupnost; set => dostupnost = value; }
        public int Fotografija { get => fotografija; set => fotografija = value; }
        public double OsnovnaCijena { get => osnovnaCijena; set => osnovnaCijena = value; }
        public Transmisija Transmisija1 { get => transmisija; set => transmisija = value; }
    }
}
