using MediatR;

namespace HomeManagement.Application.CQRS.HomeMembers.Commands.RemoveHomeMember
{
    public class RemoveHomeMemberCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
