using MediatR;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetHomeMemberAnnualIncome
{
    public class GetHomeMemberAnnualIncomeQuery : IRequest<GetHomeMemberAnnualIncomeViewModel>
    {
        public int HomeMemberId { get; set; }

        public int Year { get; set; }
    }
}
