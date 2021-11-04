using HomeManagement.Application.Abstractions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.Incomes.Commands.RemoveIncome
{
    public class RemoveIncomeHandler : IRequestHandler<RemoveIncomeCommand, int>
    {
        private IIncomeRepository _incomeRepository;

        public RemoveIncomeHandler(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }

        public async Task<int> Handle(RemoveIncomeCommand request, CancellationToken cancellationToken)
        {
            var income = await _incomeRepository.GetByIdAsync(request.Id);

            await _incomeRepository.DeleteAsync(income);

            return income.Id;
        }
    }
}
