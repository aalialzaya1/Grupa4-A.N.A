using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class UsloviController : Controller
    {
        public IActionResult Uslovi()
        {
            return View();
        }
    }
}
