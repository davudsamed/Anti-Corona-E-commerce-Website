using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Anti_Corona.Data.Concrete.EFCore;
using Anti_Corona.Web.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Anti_Corona.Data.Abstract;
using Anti_Corona.Business.Abstract;
using Anti_Corona.Business.Concrete;
using System.Globalization;

namespace Anti_Corona.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //services.AddDbContext<AntiCoronaContext>(options =>
            // options.UseSqlServer(
            //     Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<ACContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ACContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;

                // Lockout                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".Anti-Corona.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });
            //Dependency Injection
            services.AddScoped<IProductRepository, EfCoreProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddScoped<ICartRepository, EfCoreCartRepository>();
            services.AddScoped<ICartService, CartManager>();

            services.AddScoped<IOrderRepository, EfCoreOrderRepository>();
            services.AddScoped<IOrderService, OrderManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration,UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var cultureInfo = new CultureInfo("tr-TR");
            cultureInfo.NumberFormat.NumberDecimalSeparator = ".";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
        
                endpoints.MapControllerRoute(
           name: "shop",
           pattern: "shop/{url?}",
           defaults: new { controller = "Shop", action = "Index" }
        );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedIdentity.Seed(userManager, roleManager, configuration).Wait();
        }
    }
}
