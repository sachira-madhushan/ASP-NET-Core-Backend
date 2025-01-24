using ASP_NET_Core_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_NET_Core_Backend.DB
{
    public class ApiDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SocialMedia;");
        }

    }
}
