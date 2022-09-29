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
      try
      {
         var DbUsers = await _context.Users.ToListAsync();
         var users = new List<Domain.Entities.User>();
         foreach(var DbUser in DbUsers)
         {
            var user = Domain.Entities.User.Crate(
               DbUser.FirstName,
               DbUser.LastName,
               DbUser.Email,
               DbUser.Phone, DbUser.Rate
            );
            users.Add(user);
         }
         return users;
      } 
      catch(Exception ex)
      {
         Console.WriteLine("[Persistance Layer - UserRepository] ", ex.Message);
         return null;
      }
   }

   public async Task<Domain.Entities.User> GetByEmail(string email)
   {
      try
      {
         var DbUser = await _context
                                          .Users
                                          .Where(U => U.Email == email)
                                          .FirstOrDefaultAsync();
         var user = Domain.Entities.User.Crate(
            DbUser.FirstName,
            DbUser.LastName,
            DbUser.Email,
            DbUser.Phone, DbUser.Rate            
         );
         return user;
      }
      catch(Exception ex)
      {
         Console.WriteLine("[Persistance Layer - UserRepository] ", ex.Message);
         return null;
      }
   }

   public async Task<Domain.Entities.User> GetById(int id)
   {
      try
      {
         var DbUser = await _context
                                          .Users
                                          .FindAsync(id);
         var user = Domain.Entities.User.Crate(
            DbUser.FirstName,
            DbUser.LastName,
            DbUser.Email,
            DbUser.Phone, DbUser.Rate            
         );
         return user;
      }
      catch(Exception ex)
      {
         Console.WriteLine("[Persistance Layer - UserRepository] ", ex.Message);         
         return null;
      }
   }

   public async Task<bool> Update(int id, Domain.Entities.User user)
   {
      try
      {
         var DbUser = await _context
                                          .Users
                                          .FindAsync(id);
         
         DbUser.FirstName = user.FirstName;
         DbUser.LastName = user.LastName;
         DbUser.Email = user.Email;
         DbUser.Phone = user.Phone;
         DbUser.Rate = user.Rate;

         await _context.SaveChangesAsync();
         return true;
      }
      catch(Exception ex)
      {
         Console.WriteLine("[Persistance Layer - UserRepository] ", ex.Message);         
         return false;
      }
   }
}