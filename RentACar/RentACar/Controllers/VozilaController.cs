using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class VozilaController : Controller
    {
        public IActionResult Vozila()
        {
            return View();
        }
    }
}
