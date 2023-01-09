using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisLeaners.Data;
using CapenexisLeaners.Models;

namespace CapenexisLeaners.Pages.Leaners
{
    public class IndexModel : PageModel
    {
        private readonly CapenexisLeaners.Data.CapenexisLeanersContext _context;

        public IndexModel(CapenexisLeaners.Data.CapenexisLeanersContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
