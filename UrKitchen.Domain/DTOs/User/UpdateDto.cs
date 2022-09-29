namespace UrKitchen.Domain.DTOs.User;
public record UpdateDto(
   string firstName,
   string lastName,
   string email,
   string phone
);