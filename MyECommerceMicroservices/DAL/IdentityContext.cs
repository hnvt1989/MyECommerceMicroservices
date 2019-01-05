using MyECommerceMicroservices.Models.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MyECommerceMicroservices.DAL
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {

        public IdentityContext()
            : base("DefaultConnection")
        {
        }

        public static IdentityContext Create()
        {

              return new IdentityContext();
        }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //}

        
    }
}