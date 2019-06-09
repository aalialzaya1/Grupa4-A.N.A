using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PocetnaController : Controller
    {
        public IActionResult Pocetna()
        {
            return View();
        }
        public IActionResult PrijavaOnClick()
        {
            return View("../Prijava/Prijava");
        }
    }
}
