using System;
using System.Collections.Generic;

namespace RentACar.Models
{
    public class Klijent : Osoba
    {
        private List<int> racuniUBanci = new List<int>();

        public List<int> RacuniUBanci { get => racuniUBanci; set => racuniUBanci = value; }

        public Klijent()
        {
        }

        public Klijent(List<int> racuniUBanci)
        {
            this.RacuniUBanci = racuniUBanci;
        }

        void rezervisi() { 
        }
    }
}
