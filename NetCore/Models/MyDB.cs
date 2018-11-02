using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Models
{
    public class MyDB : DbContext
    {
        public MyDB(DbContextOptions<MyDB> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
}
