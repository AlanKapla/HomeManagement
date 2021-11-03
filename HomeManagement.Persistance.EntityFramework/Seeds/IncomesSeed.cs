using HomeManagement.Domain.Entities;
using System;
using System.Collections.Generic;

namespace HomeManagement.Persistance.EntityFramework.Seeds
{
    public class IncomesSeed
    {
        public static List<Income> Get()
        {
            var incomesSeed = new List<Income>()
            {
                new Income()
                {
                    IncomeDate = new DateTime(2021,11,2),
                    IncomeAmount =1000
                },

                new Income()
                {
                    IncomeDate = new DateTime(2021,10,2),
                    IncomeAmount =3000
                },

                new Income()
                {
                    IncomeDate = new DateTime(2021,8,2),
                    IncomeAmount =3000
                },

                new Income()
                {
                    IncomeDate = new DateTime(2021,11,2),
                    IncomeAmount =1000
                },

                new Income()
                {
                    IncomeDate = new DateTime(2021,10,2),
                    IncomeAmount =3000
                },

                new Income()
                {
                    IncomeDate = new DateTime(2021,8,2),
                    IncomeAmount =3000
                }
            };


            return incomesSeed;
        }
    }
}
