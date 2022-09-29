using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;

public class ChiefOrderConfig : IEntityTypeConfiguration<ChiefOrder>
{
   public void Configure(EntityTypeBuilder<ChiefOrder> builder)
   {
      builder.HasKey(CO => new {CO.ChiefId, CO.OrderId});
      builder
         .HasOne(CO => CO.Chief)
         .WithMany(chief => chief.ChiefOrders)
         .HasForeignKey(O => O.ChiefId)
         .IsRequired(true)
         .OnDelete(DeleteBehavior.Cascade);

      builder
         .HasOne(CO => CO.Order)
         .WithMany(O => O.ChiefOrders)
         .HasForeignKey(O => O.OrderId)
         .IsRequired(true)
         .OnDelete(DeleteBehavior.Cascade);
   }
}