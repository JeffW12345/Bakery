#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bakery.Data;
using Bakery.Models.Bakery.Model;

namespace Bakery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Bakery.Data.BakeryContext _context;

        public IndexModel(Bakery.Data.BakeryContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
