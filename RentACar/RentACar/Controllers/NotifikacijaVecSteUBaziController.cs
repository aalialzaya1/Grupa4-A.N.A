using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaVecSteUBaziController : Controller
    {
        public IActionResult NotifikacijaVecSteUBazi()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../Registracija/Registracija");
        }
    }
}
