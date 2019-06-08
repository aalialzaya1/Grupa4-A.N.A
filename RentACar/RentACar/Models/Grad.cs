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

        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }


    }
}
