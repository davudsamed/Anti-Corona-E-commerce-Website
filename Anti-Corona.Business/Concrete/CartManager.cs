using Anti_Corona.Business.Abstract;
using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;
        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            if (userId != null)
            {
                var cartItems = GetCartItems(userId);
                if (cartItems!=null)
                {
                    //eklemek istenilen ürün kullanıcının sepetinde var mı kontrolü
                    var index = cartItems.FindIndex(i => i.ProductId == productId);
                    //yoksa
                    if (index < 0)
                    {
                        //gelen bilgilere göre veritabanına ekledik
                        _cartRepository.Create(new CartItem()
                        {
                            ProductId = productId,
                            Quantity = quantity,
                            UserId = userId
                        });
                    }
                    //varsa ürünün miktarını 1 arttırdık
                    else
                    {
                        cartItems[index].Quantity += quantity;
                        _cartRepository.Update(cartItems[index]);
                    }
                }
                else
                {
                    _cartRepository.Create(new CartItem()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        UserId = userId
                    });
                }
               
            }
        }

        public void ClearCart(string userId)
        {
            _cartRepository.ClearCart(userId);
        }

        public void Create(CartItem entity)
        {
            _cartRepository.Create(entity);
        }

        public void Delete(CartItem entity)
        {
            _cartRepository.Delete(entity);
        }

        public void DeleteFromCart(string userId, int productId)
        {
            var cartItems = GetCartItems(userId);
            var cartItem = cartItems.Find(i => i.ProductId == productId);
            _cartRepository.Delete(cartItem);
        }

        public CartItem GetById(int id)
        {
            return _cartRepository.GetById(id);
        }

        public List<CartItem> GetCartItems(string userId)
        {
            return _cartRepository.GetCartItems(userId);
        }

        public void Update(CartItem entity)
        {
            _cartRepository.Update(entity);
        }
    }
}
