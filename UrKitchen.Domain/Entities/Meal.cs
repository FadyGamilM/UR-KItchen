namespace UrKitchen.Domain.Entities;
public class Meal : Entity
{
   private Meal(
      string mealName,
      int chiefId,
      User chief
   )
   {
      this.MealName = mealName;
      this.ChiefId = chiefId;
      this.Chief = chief;
   }

   public string MealName {get; private set;}
   public int ChiefId {get; private set;}
   public User Chief {get; private set;}
   public bool status {get; private set;} = false;

   public static Meal Create(
      string mealName,
      int chiefId,
      User chief
   )
   {
      var meal = new Meal(
         mealName,
         chiefId,
         chief
      );
      return meal;
   }

   // method to soft delete the meal
   public Meal Delete()
   {
      this.status = true;   
      return this;
   }

   public Meal UpdateMeal (string mealName)
   {
      this.MealName = mealName;
      return this;
   }
}