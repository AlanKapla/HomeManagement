using AutoMapper;
using HomeManagement.Application.Abstractions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember
{
    public class GetHomeMemberHandler : IRequestHandler<GetHomeMemberQuery, GetHomeMemberViewModel>
    {
        private IHomeMemberRepository _homeMemberRepository;
        private IMapper _mapper;

        public GetHomeMemberHandler(IHomeMemberRepository homeMemberRepository, IMapper mapper)
        {
            _homeMemberRepository = homeMemberRepository;
            _mapper = mapper;
        }

        public async Task<GetHomeMemberViewModel> Handle(GetHomeMemberQuery request, CancellationToken cancellationToken)
        {
            var homeMember = await _homeMemberRepository.GetByIdAsync(request.Id);

            return _mapper.Map<GetHomeMemberViewModel>(homeMember);
        }
    }
}