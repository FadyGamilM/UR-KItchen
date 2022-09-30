using UrKitchen.Application.UseCases.User.Queries.GetAllUsers;
using UrKitchen.API.Contracts.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UrKitchen.Application.UseCases.User.Commands.CreateUser;

namespace UrKitchen.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
   private readonly IMediator _mediator;
   public UserController(
      IMediator mediator
   )
   {
      _mediator = mediator;
   }

   [HttpGet("")]
   public async Task<IActionResult> GetAll()
   {
      // create a query
      var query = new GetUsersQuery();

      // send it to the appropriate query handler using the mediator
      var response = await _mediator.Send(query);

      // check the mediator response 
      if (response.IsSuccess == false)
      {
         return StatusCode(500, response);
      }
      
      // map the result 

      // return the response
      return Ok(response);
   }

   [HttpPost("")]
   public async Task<IActionResult> Create([FromBody] CreateUserContract userDto)
   {
      // create a command from the given api contract data 
      var command = new CreateUserCommand
      {
         FirstName = userDto.firstName,
         LastName = userDto.lastName,
         Email = userDto.email,
         Phone = userDto.phone
      };

      // send the command to the appropriate handler via mediatR
      var response = await _mediator.Send(command);

      // interpret the command handler response
      if (response.IsSuccess == false)
      {
         return StatusCode(500, response);
      }

      // map the response 

      // return the result
      return Ok(response);
   }
}
