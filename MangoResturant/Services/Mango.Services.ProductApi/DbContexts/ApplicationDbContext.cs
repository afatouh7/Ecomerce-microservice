using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductApi.DbContexts
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }


    }
}
