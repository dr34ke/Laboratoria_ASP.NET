using Laboratoria_ASP.NET.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoria_ASP.NET.Database
{
    public class ExchangesDbContext : DbContext 
    {
        public ExchangesDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<ItemEntity> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        { }

    }
}
