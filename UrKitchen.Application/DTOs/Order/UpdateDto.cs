namespace UrKitchen.Application.DTOs.Order;
public record UpdateDto(
   int clientId,
   int chiefId,
   DateTime deliveryTime,
   decimal deliveryCost,
   string deliveryLocation,
   decimal totalCost 
);