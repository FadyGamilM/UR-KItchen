namespace UrKitchen.Persistance.Models;

public class Attendee 
{
   public int Id {get; set;}
   public int InvitedMemberId {get; set;}
   public User Invitedmember {get; set;}
   public int InvitationId {get; set;}
   public DinnerInvitation Invitation {get; set;}  
}