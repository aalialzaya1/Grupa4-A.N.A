using System;
namespace RentACar.Models
{
    public class Grad
    {
        private int id;
        private String naziv;
        public Grad()
        {
        }

        public Grad(int id, string naziv)
        {
            this.id = id;
            this.Naziv = naziv;
        }

        public int Id1 { get => id; set => id = value; }
        public string Naziv1 { get => naziv; set => naziv = value; }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public String Naziv
        {
            get
            {
                return naziv;
            }
        }


    }
}
