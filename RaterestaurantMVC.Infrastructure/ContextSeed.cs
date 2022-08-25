using Microsoft.AspNetCore.Identity;
using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Infrastructure
{
    public class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole<int>(Enums.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole<int>(Enums.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole<int>(Enums.Roles.Restaurator.ToString()));
            await roleManager.CreateAsync(new IdentityRole<int>(Enums.Roles.User.ToString()));
        }

        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "artur.dorobek@gmail.com",
                Email = "artur.dorobek@gmail.com",
                FirstName = "Artur",
                LastName = "Dorobek",
                EmailConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Admin123!");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.SuperAdmin.ToString());
                }
            }
        }
    }
}
