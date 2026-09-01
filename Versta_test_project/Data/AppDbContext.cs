using Microsoft.EntityFrameworkCore;
using Versta_test_project.Models;

namespace Versta_test_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<OrderModel> Orders { get; set; }
    }
}