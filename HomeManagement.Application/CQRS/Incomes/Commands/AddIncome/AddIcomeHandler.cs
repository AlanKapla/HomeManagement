using AutoMapper;
using HomeManagement.Application.Abstractions;
using HomeManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.Incomes.Commands.AddIncome
{
    public class AddIcomeHandler : IRequestHandler<AddIncomeCommand, int>
    {
        private IIncomeRepository _incomeRepository;
        private IMapper _mapper;

        public AddIcomeHandler(IIncomeRepository incomeRepository, IMapper mapper)
        {
            _incomeRepository = incomeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddIncomeCommand request, CancellationToken cancellationToken)
        {
            var income = _mapper.Map<Income>(request);

            await _incomeRepository.AddAsync(income);

            return income.Id;
        }
    }
}
