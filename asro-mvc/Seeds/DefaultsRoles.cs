using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_mvc.Seeds
{
    public class DefaultsRoles
    {
        public static async Task TaskAsync9UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
        }
    }
}
