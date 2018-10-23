using Microsoft.EntityFrameworkCore;

namespace ChefsnDishes.Models
{
    public class ChefDishContext : DbContext
    {
        public ChefDishContext (DbContextOptions<ChefDishContext> options) : base(options) { }
        public DbSet<Chef> Chef {get;set;}
        public DbSet<Dish> Dish {get;set;}
    }
}