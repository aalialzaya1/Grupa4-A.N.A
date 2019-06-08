using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class PretragaController : Controller
    {
        public IActionResult Pretraga()
        {
            return View();
        }
    }
}
