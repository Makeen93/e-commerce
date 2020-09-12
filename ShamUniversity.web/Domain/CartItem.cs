using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShamUniversity.web.Domain
{
    public class CartItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PruductId { get; set; }
        public int Quantity { get; set; }
        public bool IsWishList { get; set; }
    }
}
