using Microsoft.AspNetCore.Identity;

namespace PWEB_2324.Services
{
    public class SeedRole : ISeedRole
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedRole(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void SeedRoles()
        {
            if (!_roleManager.RoleExistsAsync("Member").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Member";
                role.NormalizedName = "MEMBER";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
        }

        public void SeedUsers()
        {
            if(_userManager.FindByEmailAsync("client").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "client";
                user.Email = "client";
                user.NormalizedEmail = "CLIENT";
                user.NormalizedUserName = "CLIENT";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Admin2023!").Result;
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Member").Wait();
                }
            }

            if (_userManager.FindByEmailAsync("admin").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "admin";
                user.Email = "admin";
                user.NormalizedEmail = "ADMIN";
                user.NormalizedUserName = "ADMIN";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Admin2023!").Result;
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
