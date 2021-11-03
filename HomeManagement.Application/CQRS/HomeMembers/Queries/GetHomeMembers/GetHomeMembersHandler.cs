using AutoMapper;
using HomeManagement.Application.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMembers
{
    class GetHomeMembersHandler : IRequestHandler<GetHomeMembersQuery, List<GetHomeMembersViewModel>>
    {
        private IHomeMemberRepository _homeMemberRepository;
        private IMapper _mapper;

        public GetHomeMembersHandler(IHomeMemberRepository homeMemberRepository, IMapper mapper)
        {
            _homeMemberRepository = homeMemberRepository;
            _mapper = mapper;
        }

        public async Task<List<GetHomeMembersViewModel>> Handle(GetHomeMembersQuery request, CancellationToken cancellationToken)
        {
            var homeMembers = await _homeMemberRepository.GetAllAsync();

            var homeMembersOrdered = homeMembers
                .OrderBy(h => h.Surname)
                .ThenBy(h => h.FirstName);

            return _mapper.Map<List<GetHomeMembersViewModel>>(homeMembersOrdered);
        }
    }
}
