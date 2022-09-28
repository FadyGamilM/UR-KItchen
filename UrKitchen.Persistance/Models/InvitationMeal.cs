namespace UrKitchen.Persistance.Models;

public class InvitationMeal 
{
   public int MealId {get; set;}
   public Meal Meal {get; set;}
   public int InvitationId { get; set; }
   public DinnerInvitation Invitation {get; set;}
}