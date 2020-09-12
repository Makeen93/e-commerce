using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShamUniversity.web.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }

    }
}
