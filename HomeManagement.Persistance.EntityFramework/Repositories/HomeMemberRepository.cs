using HomeManagement.Application.Abstractions;
using HomeManagement.Domain.Entities;

namespace HomeManagement.Persistance.EntityFramework.Repositories
{
    public class HomeMemberRepository : BaseRepository<HomeMember>,IHomeMemberRepository
    {
        public HomeMemberRepository(HomeManagementDbContext dbContext): base(dbContext)
        {

        }
    }
}
