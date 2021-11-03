using HomeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeManagement.Persistance.EntityFramework.Seeds
{
    public class HomeMembersSeed
    {
        public static List<HomeMember> Get()
        {
            var homeMembersSeed = new List<HomeMember>()
            {
                new HomeMember()
                {
                    FirstName = "Alan",
                    Surname = "Kapla",
                    Profession = "Programmer",
                    BirthDate = new DateTime(1994,2,7),
                    Type = "Dad"
                },

                new HomeMember()
                {
                    FirstName = "Dominika",
                    Surname = "Kapla",
                    Profession = "Programmer",
                    BirthDate = new DateTime(1994,4,8),
                    Type = "Mom"
                },

                new HomeMember()
                {
                    FirstName = "Franciszek",
                    Surname = "Kapla",
                    Profession = "Student",
                    BirthDate = new DateTime(2016,7,9),
                    Type = "Son"
                },

                new HomeMember()
                {
                    FirstName = "Gabriela",
                    Surname = "Kapla",
                    Profession = "Student",
                    BirthDate = new DateTime(2019,4,16),
                    Type = "Daughter"
                }
            };

            return homeMembersSeed;
        }
    }
}
