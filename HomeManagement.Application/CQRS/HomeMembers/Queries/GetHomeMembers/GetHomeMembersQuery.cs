using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMembers
{
    public class GetHomeMembersQuery : IRequest<List<GetHomeMembersViewModel>>
    {
    }
}
