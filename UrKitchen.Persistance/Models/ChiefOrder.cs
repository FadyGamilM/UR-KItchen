namespace UrKitchen.Persistance.Models;

public class ChiefOrder
{
   public int ChiefId {get; set;}
   public User Chief {get; set;}
   public int OrderId {get; set;}
   public Order Order {get; set;}
}