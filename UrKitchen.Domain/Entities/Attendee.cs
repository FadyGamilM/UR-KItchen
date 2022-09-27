namespace UrKitchen.Domain.Entities;
public class Attendee : Entity
{
   private Attendee(
      int invitedMemberId,
      User invitedMember,
      int invitationId,
      DinnerInvitation invitation
   )
   {
      this.InvitedMemberId = invitedMemberId;
      this.Invitation = invitation;
      this.Invitedmember = invitedMember;
      this.InvitationId = invitationId;
   }
   public int InvitedMemberId {get; private set;}
   public User Invitedmember {get; private set;}
   public int InvitationId {get; private set;}
   public DinnerInvitation Invitation {get; private set;}

   public static Attendee Create(
      int invitedMemberId,
      User invitedMember,
      int invitationId,
      DinnerInvitation invitation      
   )
   {
      var attendee = new Attendee(
         invitedMemberId,
         invitedMember,
         invitationId,
         invitation
      );
      return attendee;
   }
}