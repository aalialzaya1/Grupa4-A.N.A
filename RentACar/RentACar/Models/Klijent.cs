using System;
using System.Collections.Generic;

namespace RentACar.Models
{
    public class Klijent : Osoba, IKlijentObserver, IRezervisi
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

        public void azuriraj(int stanje)
        {
            throw new NotImplementedException();
        }

        public void rezervisi()
        {
            throw new NotImplementedException();
        }
    }
}
