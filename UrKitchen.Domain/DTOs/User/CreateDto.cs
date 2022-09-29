namespace UrKitchen.Domain.DTOs.User;
public record CreateDto(
   string firstName,
   string lastName,
   string email,
   string phone
);