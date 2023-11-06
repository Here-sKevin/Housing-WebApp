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
            if (!_roleManager.RoleExistsAsync("Client").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Client";
                role.NormalizedName = "CLIENT";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
            if (!_roleManager.RoleExistsAsync("Employee").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Employee";
                role.NormalizedName = "EMPLOYEE";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
            if (!_roleManager.RoleExistsAsync("Manager").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Manager";
                role.NormalizedName = "MANAGER";
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
            if(_userManager.FindByEmailAsync("client1").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "client1";
                user.Email = "client1";
                user.NormalizedEmail = "CLIENT1";
                user.NormalizedUserName = "CLIENT1";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Admin2023!").Result;
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Client").Wait();
                }
            }
            if (_userManager.FindByEmailAsync("employee1").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "employee1";
                user.Email = "employee1";
                user.NormalizedEmail = "EMPLOYEE1";
                user.NormalizedUserName = "EMPLOYEE1";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Admin2023!").Result;
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Employee").Wait();
                }
            }
            if (_userManager.FindByEmailAsync("manager").Result == null)
            {
                IdentityUser user = new IdentityUser();
                user.UserName = "manager";
                user.Email = "manager";
                user.NormalizedEmail = "MANAGER";
                user.NormalizedUserName = "MANAGER";
                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
                user.SecurityStamp = Guid.NewGuid().ToString();

                IdentityResult result = _userManager.CreateAsync(user, "Admin2023!").Result;
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Manager").Wait();
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
