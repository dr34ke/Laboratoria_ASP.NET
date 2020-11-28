using Laboratoria_ASP.NET.Database;
using Laboratoria_ASP.NET.Entities;
using Laboratoria_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoria_ASP.NET.Controllers
{
    public class ExchangesController : Controller
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
            var vmm = new ItemEntity
            {
                Name = form.Name,
                Description = form.Description,
                IsVisible = form.IsVisible
            };
            _dbContext.Items.AddAsync(vmm);
            _dbContext.SaveChanges();
            return View("Add", vm);
        }
        public ExchangesController​(ExchangesDbContext dbContext​)
        {
            _dbContext = dbContext;
        }
        private readonly ExchangesDbContext _dbContext;
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dbContext.Items.ToList());
        }
    }
}
