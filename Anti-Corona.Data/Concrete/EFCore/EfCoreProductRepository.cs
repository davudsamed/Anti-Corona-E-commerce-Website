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
        public List<Product> GetAllProducts()
        {
            using(var context=new AntiCoronaContext())
            {
                return context.Products.Include(i=>i.Category).Include(i=>i.Images).ToList();
            }
        }
    }
}
