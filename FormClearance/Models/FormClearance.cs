using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Models
{
    public class FormClearance
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string CollegeDept { get; set; }
        public string ProblemDescription { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Recommendation { get; set; } = "NILL";
        public string TechnicalPerson { get; set; }
        public string StaffId { get; set; }
        public string Status { get; set; } = "INITIATED";
        public string UserTreated { get; set; }
        public string UserRole { get; set; }
    }
}
