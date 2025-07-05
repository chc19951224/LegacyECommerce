using LegacyECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Infrastructure
{
    public class MyDbContext : DbContext
    {
        /// 成員屬性
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        /// 構造函數
        public MyDbContext() : base("MyConnectionString")
        {

        }
    }
}
