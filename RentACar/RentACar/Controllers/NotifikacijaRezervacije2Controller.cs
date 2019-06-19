using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaRezervacije2Controller : Controller
    {
        public IActionResult NotifikacijaRezervacije2()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../RezervacijaPrijavljen/RezervacijaPrijavljen");
        }
    }
}
