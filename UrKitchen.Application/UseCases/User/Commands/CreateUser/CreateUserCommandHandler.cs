using UrKitchen.Application.Abstractions;
using MediatR;
using UrKitchen.Domain.Entities;
using UrKitchen.Application.Common;
using UrKitchen.Application.UseCases.User.Commands.CreateUser;
using UrKitchen.Application.Contracts.User;

namespace UrKitchen.Application.UseCases.User.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, HandlersResponse<CreatedUser>>
{
   private readonly IUserRepository _userRepo;
   public CreateUserCommandHandler(IUserRepository userRepo)
   {
      _userRepo = userRepo;
   }

   public async Task<HandlersResponse<CreatedUser>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
   {
      // map the command to the domain user entitiy 
      var user = Domain.Entities.User.Create(
         request.FirstName,
         request.LastName,
         request.Email,
         request.Phone
      );

      // create instance using the repository port
      var createdUser = await _userRepo.Create(user);
      
      // create a general response instance
      var response = new HandlersResponse<CreatedUser>();

      // return the general response to the api
      if (createdUser != null)
      {
         response.IsSuccess = true;
         response.Payload = createdUser;
         return response;
      }
      else
      {
         response.IsSuccess = false;
         response.Errors.Add(
            new Error
            {
               Message = "Error while creating a new user",
               StatusCode = Constants.ErrorCode.ServerError
            }
         );
         return response;
      }
   }
}