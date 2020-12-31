using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Abstract
{
    public interface IBrandRepository: IRepository<Brand>
    {
        List<Brand> GetBrands();
        Brand GetByIdWithProducts(int brandId);
    }
}