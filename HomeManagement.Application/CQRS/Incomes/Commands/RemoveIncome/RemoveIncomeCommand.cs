using MediatR;

namespace HomeManagement.Application.CQRS.Incomes.Commands.RemoveIncome
{
    public class RemoveIncomeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
