using System;
using System.ComponentModel.DataAnnotations;

namespace HomeManagement.Domain.Entities
{
    public class HomeMember
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string Type { get; set; }

        public string Profession { get; set; }
    }
}
