namespace UrKitchen.Application.DTOs.User;
public record CreateDto(
   string firstName,
   string lastName,
   string email,
   string phone
);