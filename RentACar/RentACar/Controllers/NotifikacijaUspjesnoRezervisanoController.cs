using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaUspjesnoRezervisanoController : Controller
    {
        public IActionResult NotifikacijaUspjesnoRezervisano()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../PocetnaPrijavljen/PocetnaPrijavljen");
        }
    }
}
