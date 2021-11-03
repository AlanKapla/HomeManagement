using HomeManagement.Application.Abstractions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.HomeMembers.Commands.RemoveHomeMember
{
    public class RemoveHomeMemberHandler : IRequestHandler<RemoveHomeMemberCommand,int>
    {
        private IHomeMemberRepository _homeMemberRepository;

        public RemoveHomeMemberHandler(IHomeMemberRepository homeMemberRepository)
        {
            _homeMemberRepository = homeMemberRepository;
        }

        public async Task<int> Handle(RemoveHomeMemberCommand request, CancellationToken cancellationToken)
        {
            var homeMember = await _homeMemberRepository.GetByIdAsync(request.Id);

            await _homeMemberRepository.DeleteAsync(homeMember);

            return homeMember.Id;
        }
    }
}
