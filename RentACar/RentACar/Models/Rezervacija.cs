using System;
namespace RentACar.Models
{
    public class Rezervacija
    {
        enum NacinPlacanja
        {
            GOTOVINA,
            KARTICA
        };

        private int id;
        private int brojDana;
        private Klijent klijent;
        private Vozilo vozilo;
        private int nacinPlacanja;
        private Grad gradPreuzimanja;
        private Grad gradVracanja;
        private DateTime datumPreuzimanja;
        private DateTime datumVracanja;

        public int Id { get => id; set => id = value; }
        public int BrojDana { get => brojDana; set => brojDana = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }
        public Vozilo Vozilo { get => vozilo; set => vozilo = value; }
        public int NacinPlacanja1 { get => nacinPlacanja; set => nacinPlacanja = value; }
        public Grad GradPreuzimanja { get => gradPreuzimanja; set => gradPreuzimanja = value; }
        public Grad GradVracanja { get => gradVracanja; set => gradVracanja = value; }
        public DateTime DatumPreuzimanja { get => datumPreuzimanja; set => datumPreuzimanja = value; }
        public DateTime DatumVracanja { get => datumVracanja; set => datumVracanja = value; }

        public Rezervacija()
        {
        }

        public Rezervacija(int id, int brojDana, Klijent klijent, Vozilo voizlo, int nacinPlacanja, Grad gradPreuzimanja, Grad gradVracanja, DateTime datumPreuzimanja, DateTime datumVracanja)
        {
            this.Id = id;
            this.BrojDana = brojDana;
            this.Klijent = klijent;
            this.Vozilo = voizlo;
            this.NacinPlacanja1 = nacinPlacanja;
            this.GradPreuzimanja = gradPreuzimanja;
            this.GradVracanja = gradVracanja;
            this.DatumPreuzimanja = datumPreuzimanja;
            this.DatumVracanja = datumVracanja;
        }


    }
}
