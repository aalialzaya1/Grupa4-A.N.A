using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PretragaPrijavljenController : Controller
    {
        public IActionResult PretragaPrijavljen()
        {
            return View();
        }

        public IActionResult PretragaPrijavljenOnClick()
        {
            return View("../VozilaPrijavljen/VozilaPrijavljen");
        }
    }
}
