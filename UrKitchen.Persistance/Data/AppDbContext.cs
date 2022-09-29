using Microsoft.EntityFrameworkCore;
using UrKitchen.Persistance.Models;
using UrKitchen.Persistance.Configurations;
namespace UrKitchen.Persistance.Data;
public class AppDbContext : DbContext
{
   public AppDbContext(DbContextOptions<AppDbContext> options)
      : base(options)
   { }
   
   public DbSet<User> Users {get; set;}
   public DbSet<Meal> Meals {get; set;}
   public DbSet<Order> Orders {get; set;}
   public DbSet<DinnerInvitation> Invitations {get; set;} 
   public DbSet<Attendee> Attendees {get; set;}
   public DbSet<InvitationMeal> InvitationMeals {get; set;}
   public DbSet<OrderMeal> OrderMeals {get; set;}

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.ApplyConfiguration(new OrderMealsConfig());     
      modelBuilder.ApplyConfiguration(new InvitationMealsConfig());
      modelBuilder.ApplyConfiguration(new AttendeeConfig());
      modelBuilder.ApplyConfiguration(new OrderConfig());
      modelBuilder.ApplyConfiguration(new MealConfig());
   }
}