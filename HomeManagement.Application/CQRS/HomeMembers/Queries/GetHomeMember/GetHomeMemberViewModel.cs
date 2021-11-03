using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember
{
    public class GetHomeMemberViewModel
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        [JsonIgnore]
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;

                return (today.Year - BirthDate.Year - 1) +
                        (((today.Month > BirthDate.Month) ||
                        ((today.Month == BirthDate.Month) && (today.Day >= BirthDate.Day))) ? 1 : 0);
            }
        }

        public string Type { get; set; }

        public string Profession { get; set; }
    }
}
