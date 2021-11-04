using System;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetHomeMemberAnnualIncome
{
    public class AnnualIncomeDto
    {
        public DateTime IncomeDate { get; set; }

        public float IncomeAmount { get; set; }
    }
}
