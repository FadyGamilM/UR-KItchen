using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;

public class InvitationMealsConfig : IEntityTypeConfiguration<InvitationMeal>
{
   public void Configure(EntityTypeBuilder<InvitationMeal> builder)
   {
      builder.HasKey(IM => new {IM.InvitationId, IM.MealId});

      builder.HasOne(IM => IM.Invitation)
                .WithMany(I => I.InvitationMeals)
                .HasForeignKey(IM => IM.InvitationId);

      builder.HasOne(IM => IM.Meal)
                .WithMany(M => M.InvitationMeals)
                .HasForeignKey(IM => IM.MealId);
   }
}