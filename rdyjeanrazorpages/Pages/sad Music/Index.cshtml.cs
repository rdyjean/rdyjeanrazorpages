#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rdyjeanrazorpages.Data;

namespace rdyjeanrazorpages.Pages.Jane
{
    public class IndexModel : PageModel
    {
        private readonly rdyjeanrazorpages.Data.rdyjeanrazorpagesContext _context;

        public IndexModel(rdyjeanrazorpages.Data.rdyjeanrazorpagesContext context)
        {
            _context = context;
        }

        public IList<Music> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
}
