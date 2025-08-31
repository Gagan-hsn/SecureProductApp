using Microsoft.AspNetCore.Identity;                     // for IdentityUser
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // for IdentityDbContext
using Microsoft.EntityFrameworkCore;
using SecureProductApp.Models;

namespace SecureProductApp.Data
{
    // Inherit from IdentityDbContext so Identity tables are included
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
