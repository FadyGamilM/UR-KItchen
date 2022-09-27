namespace UrKitchen.Domain.Entities;

public abstract class Entity
{
   protected Entity(int id) => Id = id;
   protected Entity(){}

   public int Id {get; protected set;}
   public DateTime CreatedAt {get; private set;} = DateTime.Now;
   public DateTime UpdatedAt {get; private set;} = DateTime.Now;


}