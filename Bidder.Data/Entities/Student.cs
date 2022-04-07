using System;
using System.Collections.Generic;
using System.Text;

namespace Bidder.Data.Entities
{
    public class Student : BaseEntity
    {
        public string RegistrationNumber { get; set; }
        public string CandidatName { get; set; }
        public string Cin { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public int MedicalTestLevel { get; set; }
    }
}
