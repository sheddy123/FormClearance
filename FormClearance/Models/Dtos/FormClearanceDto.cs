using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormClearance.Models.Dtos
{
    public class FormClearanceDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string CollegeDept { get; set; }
        public string ProblemDescription { get; set; }
        public DateTime Date { get; set; }
        public string Recommendation { get; set; }
        public string TechnicalPerson { get; set; }
        public string StaffId { get; set; }
    }
}
