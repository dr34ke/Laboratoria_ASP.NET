using Laboratoria_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoria_ASP.NET.Controllers
{
    public class ExhangesController : Controller
    {
        [HttpGet]
        public IActionResult ShowView()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowView(Form form)
        {
            var vm = new FormAdded
            {
                NumOfCharsInDecription = form.Description.Length,
                NumOfCharsInName = form.Name.Length,
                IsHidden = !form.IsVisible
            };
            return View("Add", vm);
        }
    }
}
