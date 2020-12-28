using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Business.Abstract
{
    public interface ICartService
    {
        void Create(CartItem entity);
        void Update(CartItem entity);
        void Delete(CartItem entity);
        CartItem GetById(int id);
        List<CartItem> GetCartItems(string userId);
        void AddToCart(string userId, int productId, int quantity);
        void DeleteFromCart(string userId, int productId);
    }
}
