using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShamUniversity.web.Data;
using ShamUniversity.web.Domain;

namespace ShamUniversity.web.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ShamUniversity.web.Data.ApplicationDbContext _context;

        public IndexModel(ShamUniversity.web.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
