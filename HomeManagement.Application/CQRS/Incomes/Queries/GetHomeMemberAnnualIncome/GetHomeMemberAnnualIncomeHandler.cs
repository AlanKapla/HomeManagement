using HomeManagement.Application.Abstractions;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetHomeMemberAnnualIncome
{
    public class GetHomeMemberAnnualIncomeHandler : IRequestHandler<GetHomeMemberAnnualIncomeQuery, GetHomeMemberAnnualIncomeViewModel>
    {
        private IIncomeRepository _incomeRepository;
        private IHomeMemberRepository _homeMemberRepository;

        public GetHomeMemberAnnualIncomeHandler(IIncomeRepository incomeRepository, IHomeMemberRepository homeMemberRepository)
        {
            _incomeRepository = incomeRepository;
            _homeMemberRepository = homeMemberRepository;
        }

        public async Task<GetHomeMemberAnnualIncomeViewModel> Handle(GetHomeMemberAnnualIncomeQuery request, CancellationToken cancellationToken)
        {
            var incomes = await _incomeRepository.GetHomeMemberIncomes(request.HomeMemberId);
            var homeMember = await _homeMemberRepository.GetByIdAsync(request.HomeMemberId);

            var homeMemberIncomes = incomes.Where(h => h.IncomeDate.Year == request.Year);

            var homeMemberAnnualIncomes = new GetHomeMemberAnnualIncomeViewModel()
            {
                Id = homeMember.Id,
                FirstName = homeMember.FirstName,
                Surname = homeMember.Surname,
                Sum = homeMemberIncomes.Sum(h => h.IncomeAmount),
                AnnualIncomes = homeMemberIncomes.Select(h => new AnnualIncomeDto()
                {
                    IncomeAmount = h.IncomeAmount,
                    IncomeDate = h.IncomeDate
                }).ToList()
            };

            return homeMemberAnnualIncomes;
        }
    }
}
