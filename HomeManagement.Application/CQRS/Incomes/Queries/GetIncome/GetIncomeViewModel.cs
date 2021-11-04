using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetIncome
{
    public class GetIncomeViewModel
    {
        public int Id { get; set; }

        public int HomeMemberId { get; set; }

        public DateTime IncomeDate { get; set; }

        public float IncomeAmount { get; set; }
    }
}
