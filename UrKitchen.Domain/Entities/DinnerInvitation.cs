namespace UrKitchen.Domain.Entities;

public class DinnerInvitation : Entity
{
   private DinnerInvitation(
      string title,
      DateTime time,
      string location,
      int creatorId
   )
   {
      this.Title = title;
      this.Time = time;
      this.Location = location;
      this.CreatorId = creatorId;
   }

   public string Title {get; private set;}
   public DateTime Time { get;  private set; }
   public string Location {get; private set;}
   public int CreatorId {get; private set;}
   public bool Removed {get; private set;}
   public bool Closed {get; private set;}


   public static DinnerInvitation Create(
      string title,
      DateTime time,
      string location,
      int creatorId
   )
   {
      var dinnerInvitation = new DinnerInvitation(title, time, location, creatorId);
      return dinnerInvitation;
   } 

   public DinnerInvitation Delete()
   {
      this.Removed = true;
      return this;
   }
}