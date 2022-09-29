namespace UrKitchen.Persistance.Models;

public class Order 
{
   public int Id {get; set;}
   public int ClientId {get; set;}
   public User Client {get; set;}
   public int ChiefId {get; set;}
   public User Chief {get; set;}
   public List<OrderMeal> OrderMeals {get; set;} = new();
   public DateTime DelivryTime {get; set;}
   public decimal DeliveryCost {get; set;}
   public string DeliveryLocation {get; set;}
   public decimal TotalCost {get; set;}
   public bool Delievered {get; set;} = false;
   public bool Removed {get; set;} = false;

}