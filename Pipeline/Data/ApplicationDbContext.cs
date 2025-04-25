using Microsoft.EntityFrameworkCore;
using Pipeline.Models;


namespace Pipeline.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }


        public DbSet<Miniature> Miniatures { get; set; }
    }
}
