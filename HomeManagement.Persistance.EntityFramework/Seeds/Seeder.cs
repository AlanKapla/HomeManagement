using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeManagement.Persistance.EntityFramework.Seeds
{
    public class Seeder
    {
        private readonly HomeManagementDbContext _dbContext;

        public Seeder(HomeManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            var homeMembers = HomeMembersSeed.Get();
            var incomes = IncomesSeed.Get();

            if (!_dbContext.HomeMembers.Any())
            {
                _dbContext.HomeMembers.AddRange(homeMembers);
                _dbContext.SaveChanges();
            }

            if (!_dbContext.Incomes.Any())
            {
                foreach (var income in incomes)
                {
                    income.HomeMemberId = homeMembers.FirstOrDefault().Id;
                }

                _dbContext.Incomes.AddRange(incomes);
                _dbContext.SaveChanges();
            }



        }
    }
}
