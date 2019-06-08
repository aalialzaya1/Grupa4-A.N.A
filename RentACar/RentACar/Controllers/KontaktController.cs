using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Models;

namespace RentACar.Controllers
{
    public class KontaktController : Controller
    {
        public IActionResult Kontakt()
        {
            ViewData["Message"] = "Informacije: ";

            return View();
        }
    }
}
