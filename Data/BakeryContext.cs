#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bakery.Models.Bakery.Model;

namespace Bakery.Data
{
    public class BakeryContext : DbContext
    {
        public BakeryContext (DbContextOptions<BakeryContext> options)
            : base(options)
        {
        }

        public DbSet<Bakery.Models.Bakery.Model.Product> Product { get; set; }
    }
}
