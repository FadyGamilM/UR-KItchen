namespace UrKitchen.Application.DTOs.User;
public record UpdateDto(
   string firstName,
   string lastName,
   string email,
   string phone
);