using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CarsDotNetCore.Entity;

namespace CarsDotNetCore.DAL.Data
{
    public class CarsDbContext:DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        { 
        }
        public DbSet<CarsDetails> CarsDetails { get; set; } //Creating DbCOntext
    }
}
