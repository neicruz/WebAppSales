using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcVersion.Models;

namespace SalesWebMvcVersion.Data
{
    public class SalesWebMvcVersionContext : DbContext
    {
        public SalesWebMvcVersionContext (DbContextOptions<SalesWebMvcVersionContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord{ get; set; }
    }
}
