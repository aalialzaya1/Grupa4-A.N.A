using System;
using System.Collections.Generic;

namespace RentACar.Models
{
    public class Menadzer : Osoba
    {
        private List<Racun> racuni = new List<Racun>();

        public List<Racun> Racuni { get => racuni; set => racuni = value; }

        public Menadzer()
        {
        }

        public Menadzer(List<Racun> racuni)
        {
            Racuni = racuni;
        }
    }
}
