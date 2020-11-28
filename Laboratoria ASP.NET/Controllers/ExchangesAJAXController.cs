using Laboratoria_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Laboratoria_ASP.NET.Controllers
{
    public class ExchangesAJAXController : Controller
    {
        [HttpGet]
        public IActionResult ShowViewAJAX()
        {
            return View();
        }
    }
}
