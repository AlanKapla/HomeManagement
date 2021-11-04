using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Application.CQRS.Incomes.Queries.GetHomeMemberAnnualIncome
{
    public class GetHomeMemberAnnualIncomeViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public float Sum { get; set; }

        public List<AnnualIncomeDto> AnnualIncomes { get; set; }
    }
}
