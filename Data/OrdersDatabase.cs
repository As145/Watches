using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Watches.Models;

namespace Watches.Data
{
    public class OrdersDatabase : IdentityDbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public OrdersDatabase(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
