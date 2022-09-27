namespace UrKitchen.Domain.Entities;
public class OrdersMeals : Entity
{
   private OrdersMeals(
      int mealId,
      int orderId,
      Meal meal,
      Order order
   )
   {
      this.MealId = mealId;
      this.Meal = meal;
      this.OrderId = orderId;
      this.Order = order;
   }
   
   public int MealId {get; private set;}
   public Meal Meal {get; private set;}
   public int OrderId {get; private set;}
   public Order Order {get; private set;}

   public static OrdersMeals Create(
      int mealId,
      int orderId,
      Meal meal,
      Order order
   )
   {
      var orderMeal = new OrdersMeals(
         mealId,
         orderId,
         meal,
         order
      );
      return orderMeal;
   }
}