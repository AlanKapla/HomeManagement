using HomeManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeManagement.Application.Abstractions
{
    public interface IIncomeRepository : IAsyncRepository<Income>
    {
        Task<List<Income>> GetHomeMemberIncomes(int homeMemberId);
    }
}
