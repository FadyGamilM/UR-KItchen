namespace UrKitchen.Domain.Entities;
public class Meal : Entity
{
   private Meal(
      string mealName,
      int ownerId,
      User owner
   )
   {
      this.MealName = mealName;
      this.OwnerId = ownerId;
      this.Owner = owner;
   }

   public string MealName {get; private set;}
   public int OwnerId {get; private set;}
   public User Owner {get; private set;}
   public bool status {get; private set;} = false;

   public static Meal Create(
      string mealName,
      int ownerId,
      User owner
   )
   {
      var meal = new Meal(
         mealName,
         ownerId,
         owner
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