using UrKitchen.Domain.DTOs.Order;
using UrKitchen.Domain.Entities;
namespace UrKitchen.Application.Abstractions;
public interface IOrderRepository
{
   //! Create New Order  
   Task<bool> Create(CreateDto orderDto);

   //! Get All Orders given the order-creator id
   Task<IEnumerable<Order>> GetAllByChiefId(int chiefId);

   //! Get All Orders given the order-client id
   Task<IEnumerable<Order>> GetAllByClientId(int clientId);

   //! Get specific order by its id given the chief id
   Task<Order> GetOrderByChiefId(int cheifId, int orderId);

   //! Get specific order by its id given the client id
   Task<Order> GetOrderByClientId(int clientId, int orderId);

   //! Update the delivery time of a specific order given the order id
   Task<bool> Update(int orderId, UpdateDto orderDto);
 
}
