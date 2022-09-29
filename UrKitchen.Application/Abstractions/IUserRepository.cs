using UrKitchen.Domain.DTOs.User;
using UrKitchen.Domain.Entities;
namespace UrKitchen.Application.Abstractions;
public interface IUserRepository
{
   //! Create new user 
   Task<bool> Create(User user);

   //! Get All Users
   Task<IEnumerable<User>> GetAll();

   //! Get User By Id
   Task<User> GetById(int id);

   //! Get User By Email 
   Task<User> GetByEmail(string email);
   
   //! Update User By Given the user's id
   Task<bool> Update(int id, User user); 
}