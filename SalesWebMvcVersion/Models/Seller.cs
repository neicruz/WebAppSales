﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcVersion.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double  BaseSaraly { get; set; }
        public Department Department{ get; set; }
        public int DepartmentId{ get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSaraly, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSaraly = baseSaraly;
            Department = department;
        }

        public void AddSeller(SalesRecord sr)
        {
            Sales.Add(sr); 
        }
        public void RemoveSeller(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);

        }
    }
}
