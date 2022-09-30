using MediatR;
using UrKitchen.Application.Abstractions;
using UrKitchen.Application.Common;
using UrKitchen.Application.UseCases.User.Queries.GetAllUsers;
using UrKitchen.Domain;

namespace UrKitchen.Application.UseCases.User.Queries.GetAllUsers;

public class GetUsersQueryHandler
   : IRequestHandler<GetUsersQuery, HandlersResponse<IEnumerable<Domain.Entities.User>>>
{
   private readonly IUserRepository _userRepo;
   public GetUsersQueryHandler(IUserRepository userRepo)
   {
      _userRepo = userRepo;
   }
   public async Task<HandlersResponse<IEnumerable<Domain.Entities.User>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
   {
      // use the ports that are implemented by the infrastructure layers to deal with data from DB through repository abstractions
      var users = await _userRepo.GetAll();

      var response = new HandlersResponse<IEnumerable<Domain.Entities.User>>();

      response.Payload = users;

      response.IsSuccess = true;

      return response;      
   }
}