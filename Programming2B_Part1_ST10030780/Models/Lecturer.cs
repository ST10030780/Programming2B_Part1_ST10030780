using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Programming2B_Part1_ST10030780.Models
{
    internal class Lecturer
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public List<Claim> Claims { get; set; } = new List<Claim>();
    }
}
    

