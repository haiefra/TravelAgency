using Microsoft.EntityFrameworkCore;
using TravelAgency.Web.Data.Entities;

namespace TravelAgency.Web.Data
{
    public class DataContext : DbContext
    {
           public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Owner> Owners { get; set; }

    }
}
