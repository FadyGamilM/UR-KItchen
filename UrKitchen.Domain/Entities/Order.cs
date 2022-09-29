namespace UrKitchen.Domain.Entities;
public class Order:Entity
{
   //! Private Constructor for encapsulation
   private Order(
      int clientId,
      int chiefId,
      DateTime deliveryTime,
      decimal deliveryCost,
      string deliveryLocation,
      decimal totalCost
   )
   {
      this.ClientId = clientId;
      this.CheifId = chiefId;
      this.DelivryTime = deliveryTime;
      this.DeliveryCost = deliveryCost;
      this.DeliveryLocation = deliveryLocation;
      this.TotalCost = totalCost;
   }

   //! private setter Fields
   public int ClientId {get; private set;}
   public int CheifId {get; private set;}
   public DateTime DelivryTime {get; private set;}
   public decimal DeliveryCost {get; private set;}
   public string DeliveryLocation {get; private set;}
   public decimal TotalCost {get; private set;}
   public bool Delievered {get; private set;} = false;
   public bool Removed {get; private set;} = false;

   // we have to keep track of the the meals ids that are requested in this order 
   // this has nothing to do with the way we map the relations in DB
   // this is logical prespective only 
   private readonly List<Meal> _Meals = new ();
   // when we use .Add() we will use the private field, but for reading we can privde this public prop
   // which satisfy more encapsulation
   public IReadOnlyCollection<Meal> Meals => _Meals;

   //! Static Factory Method
   public static Order Create (
      int clientId,
      int chiefId,
      DateTime deliveryTime,
      decimal deliveryCost,
      string deliveryLocation,
      decimal totalCost   
   )
   {
      var order = new Order(
         clientId,
         chiefId,
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
      this.Removed = true;
      return this;
   }

   //! Add meal to the order 
   public Order AddMeal (Meal meal)
   {
      this._Meals.Add(meal);
      return this;
   }

}