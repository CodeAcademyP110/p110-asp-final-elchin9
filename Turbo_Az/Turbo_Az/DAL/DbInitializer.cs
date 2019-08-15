using Turbo_Az.Models;
using Turbo_Az.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.DAL
{
    public class DbInitializer
    {
        public async static Task Seed(Db_Turbo _context, UserManager<AppUser> userManager,
                                                                    RoleManager<IdentityRole> roleManager,
                                                                    IConfiguration configuration)
        {
            await _context.Database.EnsureCreatedAsync();
            if (!await roleManager.RoleExistsAsync(StaticData.Admin))
            {
                await roleManager.CreateAsync(new IdentityRole(StaticData.Admin));
            }

            if (!await roleManager.RoleExistsAsync(StaticData.Member))
            {
                await roleManager.CreateAsync(new IdentityRole(StaticData.Member));
            }

            if (await userManager.FindByNameAsync("Admin") == null)
            {
                var admin = new AppUser()
                {
                    Firstname = "Admin",
                    Lastname = "Admin",
                    Email = "ElchinSh@code.edu.az",
                    UserName = "admin",
                };

                var result = await userManager.CreateAsync(admin, "Admin123!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, StaticData.Admin);
                }
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, StaticData.Admin);
                }
            }
        }
    }
}
