using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PWEB_2324.Models;

namespace PWEB_2324.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ImovelModel> ImoveilModel { get; set; }
        public DbSet<ClientModel> ClientModel { get; set; }
        public DbSet<EmployeeModel> EmployeeModel { get; set; }
        public DbSet<ManagerModel> ManagerModel { get; set; }
        public DbSet<AdminModel> AdminModel { get; set; }
    }
}