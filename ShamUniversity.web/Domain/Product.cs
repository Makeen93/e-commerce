using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShamUniversity.web.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
        public string ImageUrl  { get; set; }

    }
}
