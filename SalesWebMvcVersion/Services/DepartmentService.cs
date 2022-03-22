using SalesWebMvcVersion.Data;
using SalesWebMvcVersion.Models;
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
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
