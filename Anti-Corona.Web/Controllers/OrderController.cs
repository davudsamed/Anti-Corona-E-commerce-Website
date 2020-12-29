using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anti_Corona.Business.Abstract;
using Anti_Corona.Web.Identity;
using Anti_Corona.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Anti_Corona.Web.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private ICartService _cartService;
        private UserManager<User> _userManager;

        public OrderController(IOrderService orderService, ICartService cartService, UserManager<User> userManager)
        {
            _orderService = orderService;
            _userManager = userManager;
            _cartService = cartService;
        }
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
            var products = _cartService.GetCartItems(userId).Select(i => new OrderItemModel()
            {
                Title = i.Product.Title,
                Price = (double)i.Product.Price * i.Quantity,
                ProductId = i.ProductId,
                Quantity = i.Quantity

            }).ToList();
            return View(new OrderItemsViewModel()
            {
                orderItems = products,
                total = products.Sum(i => i.Quantity * i.Price)
            });
        }
        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            var userId = _userManager.GetUserId(User);
            var products = _cartService.GetCartItems(userId);
            foreach (var item in products)
            {
                _orderService.Create(new Entity.OrderItem()
                {
                    ProductId=item.ProductId,
                    Quantity=item.Quantity,
                    Address = model.Address,
                    City = model.City,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Note = model.Note,
                    Phone = model.Phone,
                    UserId=userId
                });
            }
            _cartService.ClearCart(userId);
            return RedirectToAction("Index","Home");
        }

    }
}
