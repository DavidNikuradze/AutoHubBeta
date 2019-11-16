using Microsoft.EntityFrameworkCore;
using testshop.data.models;

namespace testshop.data
{
    //გასარკვევი მგონი სეთი
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base (options)
        {

        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<ShopCartItem> shopCartItems { get; set; }
    }
}
