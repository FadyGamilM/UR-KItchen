using UrKitchen.Application.Abstractions;
using UrKitchen.Persistance.Models;
using UrKitchen.Domain.Entities;
using UrKitchen.Persistance.Data;
using Microsoft.EntityFrameworkCore;

namespace UrKitchen.Persistance.Repositories;

public class UserRepository : IUserRepository
{
   // inject services 
   private readonly AppDbContext _context;
   public UserRepository(AppDbContext context)
   {
      _context = context;
   }

   // Create new user db instance
   public async Task<bool> Create(Domain.Entities.User user)
   {
      try
      {
         // create DB entity from the domain entitiy
         var newUser = new Models.User
         {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Phone = user.Phone,
            Removed = false,
            Rate = 0
         };
         
         // persist the new user entitiy
         await _context.Users.AddAsync(newUser);
         await _context.SaveChangesAsync();

         return true;
      }
      catch(Exception ex)
      {
         Console.WriteLine("[Persistance Layer - UserRepository] ", ex.Message);
         return false;
      }
   }

   // get all users from db
   public async Task<IEnumerable<Domain.Entities.User>> GetAll()
   {
      throw new NotImplementedException();
   }

   public Task<Domain.Entities.User> GetByEmail(string email)
   {
      throw new NotImplementedException();
   }

   public Task<Domain.Entities.User> GetById(int id)
   {
      throw new NotImplementedException();
   }

   public Task<bool> Update(int id, Domain.Entities.User user)
   {
      throw new NotImplementedException();
   }
}