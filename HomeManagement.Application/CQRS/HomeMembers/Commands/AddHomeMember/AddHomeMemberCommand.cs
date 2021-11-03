using MediatR;
using System;

namespace HomeManagement.Application.CQRS.HomeMembers.Commands.AddHomeMember
{
    public class AddHomeMemberCommand : IRequest<int>
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string Type { get; set; }

        public string Profession { get; set; }
    }
}
