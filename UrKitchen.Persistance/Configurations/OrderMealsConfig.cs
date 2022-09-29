using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;
public class OrderMealsConfig : IEntityTypeConfiguration<OrderMeal>
{
   public void Configure(EntityTypeBuilder<OrderMeal> builder)
   {
      // define the PK 
      builder.HasKey(OM => new {OM.OrderId, OM.MealId});

      // configure the N-1 relation with the MEAL table 
      builder.HasOne(OM => OM.Meal)
                .WithMany(M => M.OrderMeals)
                .HasForeignKey(OM => OM.MealId);

      // configure the N-1 relation with the ORDER table
      builder.HasOne(OM => OM.Order)
                .WithMany(O => O.OrderMeals)
                .HasForeignKey(OM => OM.OrderId);
   }
}