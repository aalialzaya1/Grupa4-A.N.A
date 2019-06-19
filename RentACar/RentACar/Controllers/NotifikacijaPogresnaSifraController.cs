using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaPogresnaSifraController : Controller
    {
        public IActionResult NotifikacijaPogresnaSifra()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../Prijava/Prijava");
        }
    }
}
