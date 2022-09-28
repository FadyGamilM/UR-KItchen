namespace UrKitchen.Application.DTOs.DinnerInvitation;
public record CreateDto(
   string title,
   DateTime time,
   string location,
   int creatorId
);