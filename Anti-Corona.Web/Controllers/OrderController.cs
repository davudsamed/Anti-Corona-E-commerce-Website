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

        public OrderController(IOrderService orderService, UserManager<User> userManager)
        {
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var orders = _orderService.GetOrders("11");
           /* var orderModel = new OrderModel()
            {
                
            }*/
            return View();
        }
    }
}
