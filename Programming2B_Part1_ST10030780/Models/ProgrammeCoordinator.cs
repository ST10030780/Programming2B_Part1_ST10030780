using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming2B_Part1_ST10030780.Models
{
    public class ProgrammeCoordinator
    {
        public int CoordinatorID { get; set; }
        public string Name { get; set; }

        public void ReviewClaim(Claim claim)
        {
            // Logic to review and approve/reject the claim
            claim.Status = ClaimStatus.Approved; // Example
        }
    }
}