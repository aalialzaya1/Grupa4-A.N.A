using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaNemaEmailaController : Controller
    {
        public IActionResult NotifikacijaNemaEmaila()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../Registracija/Registracija");
        }
    }
}
