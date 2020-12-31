using Anti_Corona.Business.Abstract;
using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandRepository _brandRepository;
        public BrandManager(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public void Create(Brand entity)
        {
            _brandRepository.Create(entity);
        }
        public void Update(Brand entity)
        {
            _brandRepository.Update(entity);
        }
        public void Delete(Brand entity)
        {
            _brandRepository.Delete(entity);
        }
        public Brand GetById(int id)
        {
            return _brandRepository.GetById(id);
        }
        public Brand GetByIdWithProducts(int brandId)
        {
            return _brandRepository.GetByIdWithProducts(brandId);
        }
        public List<Brand> GetBrands()
        {
            return _brandRepository.GetBrands();
        }
    }
}
