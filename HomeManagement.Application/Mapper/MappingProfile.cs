using AutoMapper;
using HomeManagement.Application.CQRS.HomeMembers.Commands.AddHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMembers;
using HomeManagement.Domain.Entities;

namespace HomeManagement.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HomeMember, GetHomeMemberViewModel>().ReverseMap();
            CreateMap<HomeMember, GetHomeMembersViewModel>().ReverseMap();
            CreateMap<AddHomeMemberCommand, HomeMember>().ReverseMap();
        }
    }
}
