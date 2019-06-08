using System;
using System.Collections.Generic;
using RentACar.Models;

namespace RentACar
{
    public interface IPretraga
    {
        List<Vozilo> trazi(Vozilo vozilo);
    }
}
