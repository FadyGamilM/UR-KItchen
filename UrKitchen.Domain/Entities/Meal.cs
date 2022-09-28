namespace UrKitchen.Domain.Entities;
public class Meal : Entity
{
   private Meal(
      string mealName,
      int chiefId
   )
   {
      this.MealName = mealName;
      this.ChiefId = chiefId;
   }

   public string MealName {get; private set;}
   public int ChiefId {get; private set;}
   public bool Removed {get; private set;} = false;

   public static Meal Create(
      string mealName,
      int chiefId
   )
   {
      var meal = new Meal(
         mealName,
         chiefId
      );
      return meal;
   }

   // method to soft delete the meal
   public Meal Delete()
   {
      this.Removed = true;   
      return this;
   }

   public Meal UpdateMeal (string mealName)
   {
      this.MealName = mealName;
      return this;
   }
}