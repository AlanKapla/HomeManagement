using FluentValidation;
using System;

namespace HomeManagement.Application.CQRS.Incomes.Commands.AddIncome
{
    public class AddIcomeCommandValidator : AbstractValidator<AddIncomeCommand>
    {
        public AddIcomeCommandValidator()
        {
            RuleFor(i => i.IncomeDate.Year).GreaterThan(1920);
            RuleFor(i => i.IncomeDate)
                .LessThanOrEqualTo(DateTime.Today)
                .WithMessage("The incom has not yet been earned");
            RuleFor(i => i.IncomeAmount).GreaterThan(0);

        }
    }
}
