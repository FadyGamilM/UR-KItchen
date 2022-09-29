using UrKitchen.Domain.Entities;
using UrKitchen.Domain.DTOs.DinnerInvitation;
namespace UrKitchen.Domain.Abstractions;
public interface IDinnerInvitation 
{
   //! Create new dinner invitation
   Task<bool> Create(CreateDto invitationDto);

   //! Get All Invitations created by specific user
   Task<IEnumerable<DinnerInvitation>> GetAll(int creatorId);
}