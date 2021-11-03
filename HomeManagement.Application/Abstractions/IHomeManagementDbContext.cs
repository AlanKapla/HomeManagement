using HomeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeManagement.Application.Abstractions
{
    public interface IHomeManagementDbContext
    {        
        DbSet<Income> Incomes { get; set; }

        DbSet<HomeMember> HomeMembers { get; set; }
    }
}
