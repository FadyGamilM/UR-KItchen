using UrKitchen.Domain.Entities;
using UrKitchen.Domain.DTOs.Attendee;
namespace UrKitchen.Domain.Abstractions;
public interface IAttendeeRepository
{
   //! Create new attendee 
   Task<bool> Create(CreateDto attendeeDto);

   //! Get All Attendees who will attend a specific invitaiton given the invitation id
   Task<IEnumerable<Attendee>> GetAllAttendees(int invitaitonId);

   //! Get All Invitations that a specific user responded to and will attend
   Task<IEnumerable<DinnerInvitation>> GetAllInvitations (int InvitedMemberId);
}