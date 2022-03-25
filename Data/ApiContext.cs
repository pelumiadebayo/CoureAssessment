using CountryDetails.Model;
using Microsoft.EntityFrameworkCore;

namespace CountryDetails.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }
        
        public DbSet<Country> Countries { get; set; }

        public DbSet<CountryDetail> CountryDetails { get; set; }
    }
}
