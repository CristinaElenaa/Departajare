using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Departajare.Models;

namespace Departajare.Data
{
    public class DepartajareContext : DbContext
    {
        public DepartajareContext (DbContextOptions<DepartajareContext> options)
            : base(options)
        {
        }

        public DbSet<Departajare.Models.Movie> Movie { get; set; }

        public DbSet<Departajare.Models.VideoGame> VideoGame { get; set; }
        public DbSet<Departajare.Models.Review> Review { get; set; }
    }
}
