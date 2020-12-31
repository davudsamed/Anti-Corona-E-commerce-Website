using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, AntiCoronaContext>, ICategoryRepository
    {
        public List<Category> GetAllCategories()
        {
            using (var context=new AntiCoronaContext())
            {
                return context.Categories.ToList();
            }
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Categories
                    .Where(i => i.CategoryId == categoryId)
                    .Include(i => i.Products)
                    .FirstOrDefault();
            }
        }
    }
}
