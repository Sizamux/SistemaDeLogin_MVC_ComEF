using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaDeLogin_MVC_ComEF.Models;

namespace SistemaDeLogin_MVC_ComEF.Data
{
    //
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
