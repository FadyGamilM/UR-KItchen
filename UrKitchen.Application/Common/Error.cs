using UrKitchen.Application.Constants;
namespace UrKitchen.Application.Common;

public record Error 
{
   public string Message {get; set;}
   public ErrorCode StatusCode {get; set;}
}