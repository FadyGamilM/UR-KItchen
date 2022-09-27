using UrKitchen.Application.DTOs.User;
namespace UrKitchen.Application.IRepository;
public interface IUserRepository
{
   //! Create new user 
   async Task<bool> Create(CreateDto userDto);

   //! Get All Users
   async Task<IEnumerable<User>> GetAll();

   //! Get User By Id
   async Task<User> GetById(int id);

   //! Get User By Email 
   async Task<User> GetByEmail(string email);
   
   //! Update User By Given the user's id
   async Task<bool> Update(int id, UpdateDto userDto); 
}