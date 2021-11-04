using AutoMapper;
using HomeManagement.Application.CQRS.HomeMembers.Commands.AddHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMembers;
using HomeManagement.Application.CQRS.Incomes.Commands.AddIncome;
using HomeManagement.Application.CQRS.Incomes.Queries.GetIncome;
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

            CreateMap<AddIncomeCommand, Income>().ReverseMap();
            CreateMap<Income, GetIncomeViewModel>().ReverseMap();
            CreateMap<GetIncomeViewModel, Income>().ReverseMap();
        }
    }
}
