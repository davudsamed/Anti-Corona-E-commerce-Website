using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace Anti_Corona.Business.Abstract
{
    public interface IProductService
    {
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        Product GetById(int id);
        List<Product> GetAllProducts(string category);
        List<Product> GetMostPopularProducts();
        List<Product> GetRelatedProducts();
        int GetProductCount();
        Product GetProductDetails(int id);
        List<Product> IsHomePage();

    }
}
