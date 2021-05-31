using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectD.Controllers
{
    public class TrainingController : Controller
    {
        public IActionResult Trainingen()
        {
            return View();
        }
    }
}
