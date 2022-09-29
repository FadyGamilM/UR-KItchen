using UrKitchen.Domain.DTOs.Meal;
using UrKitchen.Domain.Entities;
namespace UrKitchen.Domain.Abstractions;
public interface IMealRepository 
{
   //! Create new meal
   Task<bool> Create(CreateDto mealDto); 

   //! Get All Meals
   Task<IEnumerable<Meal>> GetAll();  

   //! Get Meal By Id
   Task<Meal> GetById(int id);

   //! Remove Meal by id [soft delete]
   Task<bool> Delete(int id);

   //! update meal name 
   Task<bool>UpdateName(UpdateDto mealDto);
}