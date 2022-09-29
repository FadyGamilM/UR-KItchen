namespace UrKitchen.Persistance.Models;

public class Order 
{
   public int Id {get; set;}
   public List<ClientOrder> ClientOrders {get; set;}
   public List<ChiefOrder> ChiefOrders {get; set;}
   public List<OrderMeal> OrderMeals {get; set;} = new();
   public DateTime DelivryTime {get; set;}
   public decimal DeliveryCost {get; set;}
   public string DeliveryLocation {get; set;}
   public decimal TotalCost {get; set;}
   public bool Delievered {get; set;} = false;
   public bool Removed {get; set;} = false;

}