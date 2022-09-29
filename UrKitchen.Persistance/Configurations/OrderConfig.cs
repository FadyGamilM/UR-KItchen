using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;

public class OrderConfig : IEntityTypeConfiguration<Order>
{
   public void Configure(EntityTypeBuilder<Order> builder)
   {
      builder.HasKey(O => O.Id);
      builder
         .HasOne(O => O.Client)
         .WithMany(client => client.CreatedOrders)
         .HasForeignKey(O => O.ClientId)
         .IsRequired(true)
         .OnDelete(DeleteBehavior.Cascade);

      builder
         .HasOne(O => O.Chief)
         .WithMany(chief => chief.RequestedOrders)
         .HasForeignKey(O => O.ChiefId)
         .IsRequired(true)
         .OnDelete(DeleteBehavior.Cascade);
   }
}