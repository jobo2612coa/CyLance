﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeABoard.Controllers
{
    public class TournamentController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}