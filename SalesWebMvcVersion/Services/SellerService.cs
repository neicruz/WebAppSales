using SalesWebMvcVersion.Data;
using SalesWebMvcVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcVersion.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcVersionContext _context;

        public SellerService(SalesWebMvcVersionContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }

    
}
