#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesVideoclub.Models;

namespace RazorPagesVideoclub.Data
{
    public class RazorPagesVideoclubContext : DbContext
    {
        public RazorPagesVideoclubContext (DbContextOptions<RazorPagesVideoclubContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesVideoclub.Models.Movie> Movie { get; set; }
    }
}
