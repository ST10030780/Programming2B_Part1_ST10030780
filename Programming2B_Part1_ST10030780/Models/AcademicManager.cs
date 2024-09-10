using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming2B_Part1_ST10030780.Models
{
    public class AcademicManager
    {
        public int ManagerID { get; set; }
        public string Name { get; set; }

        public void FinalApproval(Claim claim)
        {
            // Logic for final approval of the claim
            claim.Status = ClaimStatus.Approved; // Example
        }
    }
}