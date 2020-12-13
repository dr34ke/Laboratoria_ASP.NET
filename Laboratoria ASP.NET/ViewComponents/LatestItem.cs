using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratoria_ASP.NET.Database;

namespace Laboratoria_ASP.NET.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext dbContext;

        public LatestItem(ExchangesDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = dbContext.Items.OrderByDescending(x => x.Id).First();
            return View("Index", latestItem);
        }

    }
}