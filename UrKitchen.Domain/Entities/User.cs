namespace UrKitchen.Domain.Entities;

public class User : Entity
{
   //* private constructor for utilizing the factory method only for creation an instance of User entity
   private User(
      string firstName,
      string lastName,
      string email,
      decimal? rate      
   )
   {
      this.FirstName = firstName;
      this.LastName = lastName;
      this.Email = email;
      this.Rate = rate;
   }
   
   //* private properties for encapsulation 
   public string FirstName { get; private set; }

   public string LastName {get; private set;} 

   public string Email {get; private set;}

   public decimal? Rate {get; private set;} = 0;

   //* Factory Method
   public static User Crate(
      string firstName,
      string lastName,
      string email,
      decimal? rate
   )
   {
      var user = new User(
         firstName,
         lastName,
         email,
         rate
      );
      return user;
   }
}