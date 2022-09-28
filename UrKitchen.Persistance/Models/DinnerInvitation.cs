namespace UrKitchen.Persistance.Models;

public class DinnerInvitation
{
   public int Id {get; set;}
   public string Title {get; set;} 
   public int CreatorId {get; set;}
   public User Creator { get; set;}
   public List<InvitationMeal> InvitationMeals {get; set;} = new ();
   public DateTime Time { get;  set; }
   public string Location {get; set;}
   public bool Removed {get; set;}
   public bool Closed {get; set;} = false;
}