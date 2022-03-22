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

        public DbSet<SalesWebMvcVersion.Models.Department> Department { get; set; }
    }
}
