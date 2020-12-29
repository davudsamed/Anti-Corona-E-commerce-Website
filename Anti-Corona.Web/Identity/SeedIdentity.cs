using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {

            var username1 = configuration["Admin1:AdminUser:username"];
            var email1 = configuration["Admin1:AdminUser:email"];
            var password1 = configuration["Admin1:AdminUser:password"];

            var username2 = configuration["Admin2:AdminUser:username"];
            var email2 = configuration["Admin2:AdminUser:email"];
            var password2 = configuration["Admin2:AdminUser:password"];

            var username3 = configuration["Admin3:AdminUser:username"];
            var email3 = configuration["Admin3:AdminUser:email"];
            var password3 = configuration["Admin3:AdminUser:password"];


            if ((await userManager.FindByNameAsync(username1) == null )&& (await userManager.FindByNameAsync(username2)) == null && (await userManager.FindByNameAsync(username3) == null))
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
                await roleManager.CreateAsync(new IdentityRole("user"));

                var admin1 = new User()
                {
                    UserName = username1,
                    Email = email1,
                    FirstName = "Ahmet Selim",
                    LastName = "Öztürk",
                    EmailConfirmed = true
                };
                var admin2 = new User()
                {
                    UserName = username2,
                    Email = email2,
                    FirstName = "Davud Samet",
                    LastName = "Tombul",
                    EmailConfirmed = true
                };
                var admin3 = new User()
                {
                    UserName = username3,
                    Email = email3,
                    FirstName = "Özgür Ulaş",
                    LastName = "Karabulut",
                    EmailConfirmed = true
                };
         
                var adminResult1 = await userManager.CreateAsync(admin1, password1);
                if (adminResult1.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin1, "admin");

                }
                var adminResult2 = await userManager.CreateAsync(admin2, password2);
                if (adminResult2.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin2, "admin");

                }
                var adminResult3 = await userManager.CreateAsync(admin3, password3);
                if (adminResult3.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin3, "admin");
                }


            }
        }
    }
}
