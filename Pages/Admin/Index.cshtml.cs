#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesVideoclub.Data;
using RazorPagesVideoclub.Models;

namespace RazorPagesVideoclub.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesVideoclub.Data.RazorPagesVideoclubContext _context;

        public IndexModel(RazorPagesVideoclub.Data.RazorPagesVideoclubContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
