using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Abstract
{

    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetAllProducts(string category);
        List<Product> GetMostPopularProducts();
        List<Product> GetRelatedProducts();
        Product GetProductDetails(int id);
        List<Product> GetHomePageProducts();
        int GetProductCount();
        List<Product> SearchProducts(double? minimumPrice, double? maximumPrice, string categoryName);

    }
    
}
