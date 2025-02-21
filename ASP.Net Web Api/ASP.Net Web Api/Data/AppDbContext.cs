using Microsoft.EntityFrameworkCore;

namespace ASP.Net_Web_Api.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
    }
}
