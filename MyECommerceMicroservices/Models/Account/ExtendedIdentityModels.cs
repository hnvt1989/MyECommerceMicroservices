using System.Web;

namespace MyECommerceMicroservices.Models.Account
{
    public class ExtendedIdentityModels
    {
        public HttpPostedFileBase UserProfilePicture { get; set; }

        public byte[] Image { get; set; }
    }

    public class ExtendedProfileModels
    {
        public HttpPostedFileBase UserProfilePicture { get; set; }
        public byte[] Image { get; set; }     
    }
}