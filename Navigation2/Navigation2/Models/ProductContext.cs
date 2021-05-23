using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation2.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
