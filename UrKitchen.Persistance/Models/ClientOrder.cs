namespace UrKitchen.Persistance.Models;

public class ClientOrder
{
   public int ClientId {get; set;}
   public User Client {get; set;}
   public int OrderId {get; set;}
   public Order Order {get; set;}
}