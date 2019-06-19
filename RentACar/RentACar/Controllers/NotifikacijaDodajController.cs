using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaDodajController : Controller
    {
        public IActionResult NotifikacijaDodaj()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../dodajVozilo/dodajVozilo");
        }
    }
}
