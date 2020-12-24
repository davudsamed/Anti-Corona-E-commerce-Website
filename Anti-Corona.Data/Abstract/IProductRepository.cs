using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetAllProducts();
    }
}
