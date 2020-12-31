using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public class EfCoreBrandRepository : EfCoreGenericRepository<Brand, AntiCoronaContext>, IBrandRepository
    {
        public Brand GetByIdWithProducts(int brandId)
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Brands
                    .Where(i => i.Id == brandId)
                    .Include(i => i.Products)
                    .FirstOrDefault();
            }
        }

        public List<Brand> GetBrands()
        {
            using (var context = new AntiCoronaContext())
            {
                return context.Brands
                    .Include(i => i.Products)
                    .OrderBy(i => i.Name)
                    .ToList();
            }
        }

    }
}