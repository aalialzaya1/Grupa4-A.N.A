﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace RentACar.Controllers
{
    public class RegistracijaController : Controller
    {
        public IActionResult Registracija()
        {
            return View();
        }
    }
}
