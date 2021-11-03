using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember
{
    public class GetHomeMemberQuery : IRequest<GetHomeMemberViewModel>
    {
        public int Id { get; set; }
    }
}
