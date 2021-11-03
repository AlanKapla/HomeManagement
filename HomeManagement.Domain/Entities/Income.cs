using System;
using System.ComponentModel.DataAnnotations;

namespace HomeManagement.Domain.Entities
{
    public class Income
    {
        [Key]
        public int Id { get; set; }
       
        public HomeMember HomeMember { get; set; }

        public int HomeMemberId { get; set; }

        public DateTime IncomeDate { get; set; }

        public float IncomeAmount { get; set; }
    }
}
