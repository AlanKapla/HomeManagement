using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetIncome
{
    public class GetIncomeQuery : IRequest<GetIncomeViewModel>
    {
        public int Id { get; set; }
    }
}
