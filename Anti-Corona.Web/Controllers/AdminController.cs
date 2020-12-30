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
    public class AdminController : Controller
    {
        private UserManager<User> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IProductService _productService;
        private IOrderService _orderService;
        public AdminController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,IProductService productService,IOrderService orderService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _productService = productService;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var deneme = _orderService.GetLastSalersProduct();
            return View(new AdminDashboardViewModel()
            { 
                ProductCount=_productService.GetProductCount(),
                UserCount=_userManager.Users.Count(),
                Revenue=_orderService.GetTotalGain(),
                lastSalersProduct=_orderService.GetLastSalersProduct().Select(i=> new OrderItemModel()
                {
                    Title = i.Product.Title,
                    Price = (double)i.Product.Price * i.Quantity,
                    ProductId = i.ProductId,
                    Quantity = i.Quantity
                }).ToList()
            });
        }
        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }
        public async Task<IActionResult> UserEdit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var selectedRoles = await _userManager.GetRolesAsync(user);
                var roles = _roleManager.Roles.Select(i => i.Name);

                ViewBag.Roles = roles;
                return View(new UserDetailModel()
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    EmailComfirmed = user.EmailConfirmed,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    SelectedRoles = selectedRoles
                });
            }
            return Redirect("/admin/UserList");
        }

        [HttpPost]
        public async Task<IActionResult> UserEdit(UserDetailModel model, string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (user != null)
                {
                    user.FirstName = model.FirstName;
                    user.LastName = model.LastName;
                    user.Email = model.Email;
                    user.Address = model.Address;
                    user.PhoneNumber = model.PhoneNumber;
                    user.EmailConfirmed = model.EmailComfirmed;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                    {
                        var userRoles = await _userManager.GetRolesAsync(user);
                        selectedRoles = selectedRoles ?? new string[] { };
                        await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles).ToArray<string>());
                        await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles).ToArray<string>());

                        return Redirect("/admin/UserList");
                    }
                }
                return Redirect("/admin/UserList");
            }
            return View(model);
        }
        public async Task<IActionResult> UserDelete(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.DeleteAsync(user);
            return Redirect("/admin/UserList");
        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.Name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }
        public async Task<IActionResult> RoleEdit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonmembers = new List<User>();

            foreach (var user in _userManager.Users.ToList())
            {
                var list = await _userManager.IsInRoleAsync(user, role.Name)
                                ? members : nonmembers;
                list.Add(user);
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonmembers
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }

                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("", error.Description);
                            }
                        }
                    }
                }
            }
            return Redirect("/admin/role/" + model.RoleId);
        }
        public async Task<IActionResult> RoleDelete(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return Redirect("/admin/RoleList");
        }
        public IActionResult ProductList()
        {
            return View(_productService.GetAllProducts(""));
        }
        public IActionResult ProductDelete(int productId)
        {
            var product = _productService.GetById(productId);
            if (product!=null)
            {
                _productService.Delete(product);
            }
            return Redirect("/admin/ProductList");

        }

    }
}
