using Microsoft.EntityFrameworkCore;
using TestWebApp.Models;

namespace TestWebApp.Data
{
    public class DbContextClass: DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options)
           : base(options)
        {
        }

        // DbSet properties for entity classes
        public DbSet<userLoginDetails_result> userLoginDetails { get; set; }

        public DbSet<UserPersonalInformationModel> userPersonalInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<userLoginDetails_result>().HasNoKey();
        }
    }
}
