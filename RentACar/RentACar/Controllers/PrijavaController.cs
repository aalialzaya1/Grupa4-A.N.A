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
    }
}
