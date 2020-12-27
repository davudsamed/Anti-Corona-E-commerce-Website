using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, Name = "Maskeler", ImageUrl = "maske.jpg" },
                new Category() { CategoryId = 2, Name = "Eldivenler", ImageUrl = "eldiven.jpg" },
                new Category() { CategoryId = 3, Name = "Dezenfektanlar", ImageUrl = "dezenfektan.jpg" },
                new Category() { CategoryId = 4, Name = "Siperlikler", ImageUrl = "siperlik.jpg" }
        );
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, CategoryId = 1, Description = "Güzel maske", Title = "Maske", Price = 100, Stock = 100, Date = new DateTime(2020, 12, 27, 13, 30, 50), IsHomePage = true, IsOnSale = true },
                new Product() { ProductId = 2, CategoryId = 1, Description = "Güzel maske1", Title = "Maske1", Price = 200, Stock = 200,Date = new DateTime(2020, 12, 26, 12, 30, 50), IsHomePage = true, IsOnSale = true }
        );
            modelBuilder.Entity<Comment>().HasData(
                new Comment() { CommentId = 1, ProductId = 1, Description = "Güzel maske" },
                new Comment() { CommentId = 2, ProductId = 2, Description = "Güzel maske1" }
        );
            modelBuilder.Entity<Image>().HasData(
                new Image() { ImageId = 1, ProductId = 1, ImageUrl = "maskeUrun1.jpg" },
                new Image() { ImageId = 2, ProductId = 2, ImageUrl = "maskeUrun2.jpg" }
        );

        }
    }
}
