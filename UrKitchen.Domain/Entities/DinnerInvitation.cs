namespace UrKitchen.Domain.Entities;

public class DinnerInvitation : Entity
{
   private DinnerInvitation()
   {

   }

   public string Title {get; private set;}
   public DateTime Time { get;  private set; }
   public string Location {get; private set;}
   public int CreatorId {get; private set;}
   public User Creator { get; private set;}
   public bool Removed {get; private set;}
   public bool Closed {get; private set;}

   public static DinnerInvitation Create()
   {
      var dinnerInvitation = new DinnerInvitation();
      return dinnerInvitation;
   } 

   public DinnerInvitation Delete()
   {
      this.Removed = true;
      return this;
   }
}