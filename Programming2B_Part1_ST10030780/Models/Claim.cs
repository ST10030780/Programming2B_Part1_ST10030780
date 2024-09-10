using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming2B_Part1_ST10030780.Models
{
    internal class Claim
    {
        public int ClaimID { get; set; }
        public DateTime ClaimDate { get; set; }
        public int LecturerID { get; set; }  // Foreign Key
        public decimal HoursWorked { get; set; }
        public decimal TotalAmount => HoursWorked * Lecturer.HourlyRate;
        public Lecturer Lecturer { get; set; }
        public List<SupportingDocument> SupportingDocuments { get; set; } = new List<SupportingDocument>();
        public ClaimStatus Status { get; set; } = ClaimStatus.Pending;
    }
}
