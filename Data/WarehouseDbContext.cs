using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WarehouseAPI.Models;

namespace WarehouseAPI.Data
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options) { }

        public DbSet<Product>? Products { get; set; }  // Creates a "Products" table
    }
}
