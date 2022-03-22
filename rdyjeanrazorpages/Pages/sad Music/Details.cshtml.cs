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
    public class DetailsModel : PageModel
    {
        private readonly rdyjeanrazorpages.Data.rdyjeanrazorpagesContext _context;

        public DetailsModel(rdyjeanrazorpages.Data.rdyjeanrazorpagesContext context)
        {
            _context = context;
        }

        public Music Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
