using Microsoft.EntityFrameworkCore;
using ShopeeShop_web.Models;
namespace ShopeeShop_web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Item> Items { get; set; }
    }
}