using Anti_Corona.Business.Abstract;
using Anti_Corona.Web.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.ViewComponents
{
    public class HeaderCartViewComponent : ViewComponent
    {

        private ICartService _cartService;
        private UserManager<User> _userManager;

        public HeaderCartViewComponent(ICartService cartService, UserManager<User> userManager)
        {
            _userManager = userManager;
            _cartService = cartService;
        }
        public IViewComponentResult Invoke()
        {
            var userId = _userManager.GetUserId((System.Security.Claims.ClaimsPrincipal)User);
            var cartItems = _cartService.GetCartItems(userId);
            ViewBag.CartItemCount = cartItems.Count();
            ViewBag.CartItemsPriceTotal = cartItems.Sum(i => i.Quantity * i.Product.Price);
            return View();
        }
    }
}
