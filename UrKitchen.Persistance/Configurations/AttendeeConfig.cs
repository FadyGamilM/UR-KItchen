using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrKitchen.Persistance.Models;
namespace UrKitchen.Persistance.Configurations;

public class AttendeeConfig : IEntityTypeConfiguration<Attendee>
{
   public void Configure(EntityTypeBuilder<Attendee> builder)
   {
      builder.HasKey(A => new {A.InvitationId, A.InvitedMemberId});

      builder.HasOne(A => A.Invitation)
                .WithMany(I => I.Attendees)
                .HasForeignKey(A => A.InvitationId);

      builder.HasOne(A => A.Invitedmember)
                .WithMany(I => I.Attendees)
                .HasForeignKey(A => A.InvitedMemberId);
                
   }
}