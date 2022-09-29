namespace UrKitchen.Application.Common;

public class HandlersResponse <T> where T : class
{
   public T Payload {get; set;}

   public bool IsSuccess {get; set;}

   public List<Error> Errors {get; set;} = new ();
}