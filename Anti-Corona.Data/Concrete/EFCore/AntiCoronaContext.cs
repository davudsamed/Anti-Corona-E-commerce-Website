using System;
using System.Collections.Generic;
using System.Text;
using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public class AntiCoronaContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=TAZEKAN\SQLEXPRESS;Initial Catalog=AntiCorona;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

    }
}
