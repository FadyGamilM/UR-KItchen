namespace UrKitchen.API.Contracts.User;
public record CreateUserContract(
   string firstName,
   string lastName,
   string email,
   string phone
);
