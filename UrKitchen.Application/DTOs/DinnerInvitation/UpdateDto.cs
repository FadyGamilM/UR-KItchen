namespace UrKitchen.Application.DTOs.DinnerInvitation;
public record UpdateDto(
   string title,
   DateTime time,
   string location,
   int creatorId
);