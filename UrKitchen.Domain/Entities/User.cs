namespace UrKitchen.Domain.Entities;

public class User : Entity
{
   //* private constructor for utilizing the factory method only for creation an instance of User entity
   private User(
      string firstName,
      string lastName,
      string email,
      string phone,
      decimal? rate      
   )
   {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Email = email;
      this.Phone = phone;
      this.Rate = rate;
   }
   
   //* private properties for encapsulation 
   public string FirstName { get; private set; }

   public string LastName {get; private set;} 

   public string Email {get; private set;}
   public string Phone {get; private set;}

   public decimal? Rate {get; private set;} = 0;

   public bool Removed {get; private set;} = false;

   //* Factory Method
   public static User Crate(
      string firstName,
      string lastName,
      string email,
      string phone,
      decimal? rate
   )
   {
      var user = new User(
         firstName,
         lastName,
         email,
         phone,
         rate
      );
      return user;
   }

   //* method to remove a user [soft delete]
   public User Delete()
   {
      this.Removed = true;
      return this;
   }
}