using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming2B_Part1_ST10030780.Models
{
    internal class SupportingDocument
    {
        public int DocumentID { get; set; }
        public int ClaimID { get; set; }  // Foreign Key
        public string DocumentPath { get; set; }
    }
}
