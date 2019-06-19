using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaRegistracijeController : Controller
    {
        public IActionResult NotifikacijaRegistracije()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../Registracija/Registracija");
        }
    }
}
