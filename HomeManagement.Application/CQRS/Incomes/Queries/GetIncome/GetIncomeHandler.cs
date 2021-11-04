using AutoMapper;
using HomeManagement.Application.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetIncome
{
    public class GetIncomeHandler : IRequestHandler<GetIncomeQuery, GetIncomeViewModel>
    {
        private IIncomeRepository _incomeRepository;
        private IMapper _mapper;

        public GetIncomeHandler(IIncomeRepository incomeRepository, IMapper mapper)
        {
            _incomeRepository = incomeRepository;
            _mapper = mapper;
        }

        public async Task<GetIncomeViewModel> Handle(GetIncomeQuery request, CancellationToken cancellationToken)
        {
            var income = await _incomeRepository.GetByIdAsync(request.Id);

            return _mapper.Map<GetIncomeViewModel>(income);
        }
    }
}
