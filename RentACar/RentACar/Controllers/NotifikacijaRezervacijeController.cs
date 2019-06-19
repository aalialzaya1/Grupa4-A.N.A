using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaRezervacijeController : Controller
    {
        public IActionResult NotifikacijaRezervacije()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../Prijava/Prijava");
        }
    }
}
