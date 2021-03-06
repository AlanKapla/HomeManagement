using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Application.CQRS.Incomes.Commands.AddIncome
{
    public class AddIncomeCommand : IRequest<int>
    {
        public int HomeMemberId { get; set; }

        public DateTime IncomeDate { get; set; }

        public float IncomeAmount { get; set; }
    }
}
