using Microsoft.EntityFrameworkCore;
using UrKitchen.Persistance.Models;
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
}