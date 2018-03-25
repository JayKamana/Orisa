using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orisa.Models;
using System.Data.Entity;

namespace Orisa.DAL
{
    public class StoreContext:DbContext
    {
        public DbSet <Product> Products { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}