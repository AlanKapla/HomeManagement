using FluentValidation;
using System;

namespace HomeManagement.Application.CQRS.HomeMembers.Commands.AddHomeMember
{
    public class AddHomeMemberCommandValidator : AbstractValidator<AddHomeMemberCommand>
    {
        public AddHomeMemberCommandValidator()
        {
            RuleFor(h => h.BirthDate.Year).GreaterThan(1920);
            RuleFor(h => h.BirthDate).LessThanOrEqualTo(DateTime.Today)
                .WithMessage("The person has not yet been born");

            RuleFor(h => h.FirstName).NotEmpty().Length(2, 20);
            RuleFor(h => h.Surname).NotEmpty();
        }
    }
}
