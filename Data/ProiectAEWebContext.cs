using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectAEWeb.Models;

namespace ProiectAEWeb.Data
{
    public class ProiectAEWebContext : DbContext
    {
        public ProiectAEWebContext (DbContextOptions<ProiectAEWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectAEWeb.Models.Serviciu> Serviciu { get; set; } = default!;

        public DbSet<ProiectAEWeb.Models.Marca> Marca { get; set; }

        public DbSet<ProiectAEWeb.Models.Personal> Personal { get; set; }
    }
}
