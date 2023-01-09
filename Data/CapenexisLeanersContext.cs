using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLeaners.Models;

namespace CapenexisLeaners.Data
{
    public class CapenexisLeanersContext : DbContext
    {
        public CapenexisLeanersContext (DbContextOptions<CapenexisLeanersContext> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLeaners.Models.Movie> Movie { get; set; } = default!;
    }
}
