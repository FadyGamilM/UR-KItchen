namespace UrKitchen.Domain.Entities;
public class Order:Entity
{
   //! Private Constructor for encapsulation
   private Order(
      int clientId,
      User client,
      int chiefId,
      User chief,
      DateTime deliveryTime,
      decimal deliveryCost,
      string deliveryLocation,
      decimal totalCost
   )
   {
      this.ClientId = clientId;
      this.CheifId = chiefId;
      this.Client = client;
      this.Cheif = chief;
      this.DelivryTime = deliveryTime;
      this.DeliveryCost = deliveryCost;
      this.DeliveryLocation = deliveryLocation;
      this.TotalCost = totalCost;
   }

   //! private setter Fields
   public int ClientId {get; private set;}
   public User Client {get; private set;}
   public int CheifId {get; private set;}
   public User Cheif {get; private set;}

   public DateTime DelivryTime {get; private set;}
   public decimal DeliveryCost {get; private set;}
   public string DeliveryLocation {get; private set;}
   public decimal TotalCost {get; private set;}
   public bool Delievered {get; private set;} = false;
   public bool removed {get; private set;} = false;

   //! Static Factory Method
   public static Order Create (
      int clientId,
      User client,
      int chiefId,
      User chief,
      DateTime deliveryTime,
      decimal deliveryCost,
      string deliveryLocation,
      decimal totalCost   
   )
   {
      var order = new Order(
         clientId,
         client,
         chiefId,
         chief,
         deliveryTime,
         deliveryCost,
         deliveryLocation,
         totalCost
      );
      return order;
   }

   //! mark the order as done
   public Order MarkAsDone(bool status)
   {
      this.Delievered = true;
      return this;
   }

   //! delete an order [soft delete]
   public Order Delete ()
   {
      this.removed = true;
      return this;
   }

}