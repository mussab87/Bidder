using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bidder.DashBoard.Dtos
{
    public class StudentDtos
    {
        public string RegistrationNumber { get; set; }
        public string CandidatName { get; set; }
        public string Cin { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public int MedicalTestLevel { get; set; }
        public string Weapon { get; set; }

    }
}
