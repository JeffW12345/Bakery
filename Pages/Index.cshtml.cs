using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bakery.Data;
using Bakery.Models;
using Bakery.Models.Bakery.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BakeryContext _context;
        public IndexModel(BakeryContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public Product FeaturedProduct { get; set; }

        public async Task OnGetAsync()
        {
            List<Product> prods = new List<Product>()
            {
                new Product
                {
                    Name = "Carrot Cake",
                    Description = "A scrumptious mini-carrot cake encrusted with sliced almonds",
                    Price = 8.99m,
                    ImageName = "carrot_cake.jpg"
                },
                new Product
                {
                    Name = "Lemon Tart",
                    Description = "A delicious lemon tart with fresh meringue cooked to perfection",
                    Price = 9.99m,
                    ImageName = "lemon_tart.jpg"
                },
                new Product
                {
                    Name = "Cupcakes",
                    Description = "Delectable vanilla and chocolate cupcakes",
                    Price = 5.99m,
                    ImageName = "cupcakes.jpg"
                },
                new Product
                {
                    Name = "Bread",
                    Description = "Fresh baked French-style bread",
                    Price = 1.49m,
                    ImageName = "bread.jpg"
                },
                new Product
                {
                    Name = "Pear Tart",
                    Description = "A glazed pear tart topped with sliced almonds and a dash of cinnamon",
                    Price = 5.99m,
                    ImageName = "pear_tart.jpg"
                },
                new Product
                {
                    Name = "Chocolate Cake",
                    Description = "Rich chocolate frosting cover this chocolate lover's dream",
                    Price = 8.99m,
                    ImageName = "chocolate_cake.jpg"
                }
            };
            foreach(var prod in prods)
            {
                _context.Product.Add(prod);
                await _context.SaveChangesAsync();
            }
            Products = await _context.Product.AsNoTracking().ToListAsync();
            FeaturedProduct = Products[new Random().Next(Products.Count)];
        }
    }
}
