using SalesWebMvcVersion.Data;
using SalesWebMvcVersion.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcVersion.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcVersionContext _context;

        public DepartmentService(SalesWebMvcVersionContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
