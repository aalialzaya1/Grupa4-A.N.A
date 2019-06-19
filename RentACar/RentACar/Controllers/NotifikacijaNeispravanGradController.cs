using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class NotifikacijaNeispravanGradController : Controller
    {
        public IActionResult NotifikacijaNeispravanGrad()
        {
            return View();
        }
        public IActionResult NazadOnClick()
        {
            return View("../RezervacijaPrijavljen/RezervacijaPrijavljen");
        }
    }
}
