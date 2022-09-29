using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;

public class MealConfig : IEntityTypeConfiguration<Meal>
{
   public void Configure(EntityTypeBuilder<Meal> builder)
   {
      builder
         .HasOne(M => M.Chief)
         .WithMany(chief => chief.Meals)
         .HasForeignKey(M => M.ChiefId)
         .OnDelete(DeleteBehavior.Cascade)
         .IsRequired(true);
   }
}