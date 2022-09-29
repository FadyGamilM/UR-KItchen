using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;

public class ClientOrderConfig : IEntityTypeConfiguration<ClientOrder>
{
   public void Configure(EntityTypeBuilder<ClientOrder> builder)
   {
      builder.HasKey(CO => new {CO.ClientId, CO.OrderId});
      builder
         .HasOne(CO => CO.Client)
         .WithMany(client => client.ClientOrders)
         .HasForeignKey(O => O.ClientId)
         .IsRequired(true)
         .OnDelete(DeleteBehavior.Cascade);

      builder
         .HasOne(CO => CO.Order)
         .WithMany(O => O.ClientOrders)
         .HasForeignKey(O => O.OrderId)
         .IsRequired(true)
         .OnDelete(DeleteBehavior.Cascade);
   }
}