namespace UrKitchen.Domain.Entities;

public class User : Entity
{
   //* private constructor for utilizing the factory method only for creation an instance of User entity
   private User(
      string firstName,
      string lastName,
      string email,
      string phone
   )
   {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Email = email;
      this.Phone = phone;
   }
   
   //* private properties for encapsulation 
   public string FirstName { get; private set; }

   public string LastName {get; private set;} 

   public string Email {get; private set;}
   public string Phone {get; private set;}

   public decimal Rate {get; private set;} = 0;

   public bool Removed {get; private set;} = false;

   // user can create an order, so the user domain model 
   // has to keep track of his orders, and also user can make orders 
   // from others, so he has to keep track of his requested orders
   //=> the order i have ordered from others
   private List<Order> _CreatedOrders = new ();
   public IReadOnlyCollection<Order> CreatedOrders => _CreatedOrders;
   private List<Order> _RequestedOrders = new ();
   public IReadOnlyCollection<Order> RequestedOrders => _RequestedOrders;

   // invitations 
   private List<DinnerInvitation> _Invitations = new();
   public IReadOnlyCollection<DinnerInvitation> Invitations => _Invitations;

   //* Factory Method
   public static User Create(
      string firstName,
      string lastName,
      string email,
      string phone
   )
   {
      var user = new User(
         firstName,
         lastName,
         email,
         phone
      );
      return user;
   }

   //* method to remove a user [soft delete]
   public User Delete()
   {
      this.Removed = true;
      return this;
   }

   //* use can make an order from others 
   public Order RequestOrder (Order order)
   {
      throw new NotImplementedException();
   }

}