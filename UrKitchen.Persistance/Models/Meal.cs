namespace UrKitchen.Persistance.Models;

public class Meal 
{
   public int Id {get; set;}
   public string MealName {get; set;}
   public int ChiefId {get; set;}
   public User Chief {get; set;}
   public List<OrderMeal> OrderMeals {get; set;} = new ();
   public List<InvitationMeal> InvitationMeals {get; set;} = new ();
   public bool Removed {get; set;} = false;
}