using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Watches.Models;

namespace Watches.Data
{
    public class WatchesContext : DbContext
    {
        public WatchesContext (DbContextOptions<WatchesContext> options)
            : base(options)
        {
        }

        public DbSet<Watches.Models.Booking> Booking { get; set; }

        public DbSet<Watches.Models.Brand> Brand { get; set; }

        public DbSet<Watches.Models.Customer> Customer { get; set; }
    }
}
