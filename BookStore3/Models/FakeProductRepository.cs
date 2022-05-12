using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore3.Models
{
    public class FakeProductRepository /* : IProductRepository */
    {
        public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "Maori History", Price = 25 },
            new Product { Name = "Harry Portter", Price = 79 },
            new Product { Name = "Football", Price = 35 }
        }.AsQueryable<Product>();
    }
}
