using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.Data
{
    public class StoreDataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet <Category> Categories{ get; set; }
    }
}
