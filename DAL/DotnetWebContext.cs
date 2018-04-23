using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DotnetWeb.Models;

namespace DotnetWeb.DAL
{
    public class DotnetWebContext : DbContext
    {
        public DotnetWebContext(DbContextOptions<DotnetWebContext> options) : base(options)
        {

        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}