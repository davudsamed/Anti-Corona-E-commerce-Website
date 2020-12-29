using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Abstract
{
    public interface ICartRepository:IRepository<CartItem>
    {
        List<CartItem> GetCartItems(string userId);
        void ClearCart(string userId);
    }
}
