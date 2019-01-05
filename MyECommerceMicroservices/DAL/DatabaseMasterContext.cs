
using Microsoft.EntityFrameworkCore;

namespace MyECommerceMicroservices.DAL
{
    public class DatabaseMasterContext : DbContext
    {
        public DatabaseMasterContext() : base("DefaultConnection")
        {
            
        }
    }
}