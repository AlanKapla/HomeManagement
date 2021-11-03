using AutoMapper;
using HomeManagement.Application.Abstractions;
using HomeManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.HomeMembers.Commands.AddHomeMember
{
    public class AddHomeMemberHandler : IRequestHandler<AddHomeMemberCommand, int>
    {
        private IHomeMemberRepository _homeMemberRepository;
        private IMapper _mapper;

        public AddHomeMemberHandler(IHomeMemberRepository homeMemberRepository, IMapper mapper)
        {
            _homeMemberRepository = homeMemberRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddHomeMemberCommand request, CancellationToken cancellationToken)
        {
            var homeMember = _mapper.Map<HomeMember>(request);

            await _homeMemberRepository.AddAsync(homeMember);

            return homeMember.Id;
        }
    }
}
