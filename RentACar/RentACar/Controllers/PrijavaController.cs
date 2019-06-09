using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PrijavaController : Controller
    {
        public IActionResult Prijava()
        {
            return View();
        }
        public IActionResult RegistracijaOnClick()
        {
            return View("../Registracija/Registracija");
        }
    }
}
