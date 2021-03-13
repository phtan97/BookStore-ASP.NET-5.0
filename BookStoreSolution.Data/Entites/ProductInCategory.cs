using BookStoreSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreSolution.Data.Entites
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
