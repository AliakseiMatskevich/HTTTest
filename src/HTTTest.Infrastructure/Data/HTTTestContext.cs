using HTTTest.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTTest.Infrastructure.Data
{
    public sealed class HTTTestContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public HTTTestContext(DbContextOptions<HTTTestContext> options) : base(options)
        {            
        }
    }
}
