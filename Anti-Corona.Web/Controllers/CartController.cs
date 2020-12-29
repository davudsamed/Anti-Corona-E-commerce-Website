using Anti_Corona.Business.Abstract;
using Anti_Corona.Web.Identity;
using Anti_Corona.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private IOrderService _orderService;
        private UserManager<User> _userManager;
        public CartController(ICartService cartService, IOrderService orderservice,UserManager<User> userManager)
        {
            _cartService = cartService;
            _orderService = orderservice;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var products = _cartService.GetCartItems(userId).Select(i => new CartItemModel()
            {
                Title = i.Product.Title,
                Price = (double)i.Product.Price,
                ProductId = i.ProductId,
                ImageUrl = i.Product.Images[0].ImageUrl,
                Quantity = i.Quantity

            }).ToList();

            return View(new CartItemsViewModel()
            {
                cartItems = products,
                total = products.Sum(i => i.Quantity * i.Price)
            });
        }
        [HttpPost]
        public IActionResult AddToCart(int productId,int quantity)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.AddToCart(userId, productId, quantity);
            
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            var userId = _userManager.GetUserId(User);
            _cartService.DeleteFromCart(userId, productId);
            return RedirectToAction("Index");
        }
    }
    
}
