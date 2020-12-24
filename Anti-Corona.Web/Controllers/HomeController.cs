using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Anti_Corona.Web.Models;
using Anti_Corona.Business.Abstract;

namespace Anti_Corona.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService _productService;
        private ICategoryService _categoryService;

        public HomeController(ILogger<HomeController> logger, IProductService productService,ICategoryService categoryService)
        {
            _logger = logger;
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(new IndexViewModel()
            {
                products=_productService.GetAllProducts(),
                categories=_categoryService.GetAllCategories()
            });
        }
        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ShopDetails()
        {
            return View();
        }

        public IActionResult ShopingCard()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
