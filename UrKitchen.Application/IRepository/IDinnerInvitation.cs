using UrKitchen.Domain.Entities;
using UrKitchen.Application.DTOs.DinnerInvitation;
namespace UrKitchen.Application.IRepository;
public interface IDinnerInvitation 
{
   //! Create new dinner invitation
   Task<bool> Create(CreateDto invitationDto);

   //! Get All Invitations created by specific user
   Task<IEnumerable<DinnerInvitation>> GetAll(int creatorId);
}