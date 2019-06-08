using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class RezervacijaController : Controller
    {
        public IActionResult Rezervacija()
        {
            return View();
        }
    }
}
