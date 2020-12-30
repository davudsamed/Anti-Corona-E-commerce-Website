using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, AntiCoronaContext>, IProductRepository
    {
        public List<Product> GetAllProducts(string category)
        {
            using (var context = new AntiCoronaContext())
            {
                var products = context.Products.Include(i => i.Category).Include(i => i.Images).AsQueryable();

                if (!string.IsNullOrEmpty(category))
                {

                    products = products.Include(i => i.Category).Include(i => i.Images).Where(i => i.Category.Name == category);

                }
                return products.ToList();
            }
        }

        public List<Product> GetMostPopularProducts()
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Products.Include(i => i.Category).Include(i => i.Images).OrderBy(i => i.Stock).Take(3).ToList();
            }
        }

        public List<Product> GetRelatedProducts()
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Products.Include(i => i.Category).Include(i => i.Images).OrderByDescending(i => i.Date).Take(4).ToList();
            }
        }

        public Product GetProductDetails(int id)
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Products.Include(i => i.Category).Include(i => i.Comments).Include(i => i.Images).FirstOrDefault(p => p.ProductId == id);
            }
        }

        public List<Product> GetHomePageProducts()
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Products.Include(i => i.Images).Where(i => i.IsHomePage == true).ToList();
            }
        }

        public int GetProductCount()
        {
            using (var context=new AntiCoronaContext())
            {
                return context.Products.Count();
            }
        }

       
    }
}
