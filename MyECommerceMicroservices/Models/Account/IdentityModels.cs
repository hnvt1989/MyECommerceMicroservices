using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyECommerceMicroservices.Models.Account
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here

            ClaimsPrincipal claimsPrincipal = await _claimsPrincipalFactory.CreateAsync(user);
            ((ClaimsIdentity)claimsPrincipal.Identity).AddClaim(new Claim("user_id", user.Id.ToString()));

            return userIdentity;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }
    }
}