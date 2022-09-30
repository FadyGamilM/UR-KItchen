using UrKitchen.Domain.Entities;
using MediatR;
using UrKitchen.Application.Common;
using UrKitchen.Application.Contracts.User;

namespace UrKitchen.Application.UseCases.User.Commands.CreateUser;

public class CreateUserCommand : IRequest<HandlersResponse<CreatedUser>>
{

   public string FirstName {get; set;}
   public string LastName {get; set;}
   public string Email {get; set;}
   public string Phone  {get; set;}
}