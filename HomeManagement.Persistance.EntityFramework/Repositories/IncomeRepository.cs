using HomeManagement.Application.Abstractions;
using HomeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeManagement.Persistance.EntityFramework.Repositories
{
    public class IncomeRepository : BaseRepository<Income>, IIncomeRepository
    {
        private HomeManagementDbContext _dbContext;

        public IncomeRepository(HomeManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Income>> GetHomeMemberIncomes(int homeMemberId)
        {
            return _dbContext.Incomes.Include(i => i.HomeMember).ToListAsync();
        }
    }
}
