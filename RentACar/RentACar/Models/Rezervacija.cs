using System;
namespace RentACar.Models
{
    public class Rezervacija
    {
        enum NacinPlacanja { Gotovina, katrica };
        private int id;
        private int brojDana;
        private Klijent klijent;
        private Vozilo voizlo;
        private NacinPlacanja nacinPlacanja;
        private Grad gradPreuzimanja;
        private Grad gradVracanja;
        private DateTime datumPreuzimanja;
        private DateTime datumVracanja;

        public int Id1 { get => id; set => id = value; }
        public int BrojDana1 { get => brojDana; set => brojDana = value; }
        public Klijent Klijent1 { get => klijent; set => klijent = value; }
        public Vozilo Voizlo1 { get => voizlo; set => voizlo = value; }
        private NacinPlacanja NacinPlacanja2 { get => nacinPlacanja; set => nacinPlacanja = value; }
        public Grad GradPreuzimanja1 { get => gradPreuzimanja; set => gradPreuzimanja = value; }
        public Grad GradVracanja1 { get => gradVracanja; set => gradVracanja = value; }
        public DateTime DatumPreuzimanja1 { get => datumPreuzimanja; set => datumPreuzimanja = value; }
        public DateTime DatumVracanja1 { get => datumVracanja; set => datumVracanja = value; }

        public Rezervacija()
        {
        }

        public Rezervacija(int id, int brojDana, Klijent klijent, Vozilo voizlo, NacinPlacanja nacinPlacanja, Grad gradPreuzimanja, Grad gradVracanja, DateTime datumPreuzimanja, DateTime datumVracanja)
        {
            this.Id = id;
            this.BrojDana = brojDana;
            this.Klijent = klijent;
            this.Voizlo = voizlo;
            this.NacinPlacanja1 = nacinPlacanja;
            this.GradPreuzimanja = gradPreuzimanja;
            this.GradVracanja = gradVracanja;
            this.DatumPreuzimanja = datumPreuzimanja;
            this.DatumVracanja = datumVracanja;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public int BrojDana
        {
            get
            {
                return brojDana;
            }
        }

        public Klijent Klijent
        {
            get
            {
                return klijent;
            }
        }

        public Vozilo Voizlo
        {
            get
            {
                return voizlo;
            }
        }


        public NacinPlacanja NacinPlacanja
        {
            get
            {
                return nacinPlacanja;
            }
        }

        public Grad GradPreuzimanja
        {
            get
            {
                return gradPreuzimanja;
            }
        }

        public Grad GradVracanja
        {
            get
            {
                return gradVracanja;
            }
        }

        public DateTime DatumPreuzimanja
        {
            get
            {
                return datumPreuzimanja;
            }
        }

        public DateTime DatumVracanja
        {
            get
            {
                return datumVracanja;
            }
        }

    }
}
