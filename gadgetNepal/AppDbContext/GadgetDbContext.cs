using gadgetNepal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gadgetNepal.AppDbContext
{
    public class GadgetDbContext:DbContext

    {
        public GadgetDbContext(DbContextOptions<GadgetDbContext> options):
            base(options)
        {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

    }
}
