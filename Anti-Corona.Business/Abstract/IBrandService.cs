using System;
using System.Collections.Generic;
using System.Text;
using Anti_Corona.Entity;

namespace Anti_Corona.Business.Abstract
{
    public interface IBrandService
    {
        void Create(Brand entity);
        void Update(Brand entity);
        void Delete(Brand entity);
        Brand GetById(int id);
        List<Brand> GetBrands();
        Brand GetByIdWithProducts(int markaId);
    }
}
