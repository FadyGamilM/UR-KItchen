namespace UrKitchen.Domain.Entities;

public abstract class Entity
{
   protected Entity(Guid id) => Id = id;
   protected Entity(){}

   public Guid Id {get; protected set;}
   public DateTime CreatedAt {get; private set;} = DateTime.Now;
   public DateTime UpdatedAt {get; private set;} = DateTime.Now;


}