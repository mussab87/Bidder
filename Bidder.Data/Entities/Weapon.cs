using System;
using System.Collections.Generic;
using System.Text;

namespace Bidder.Data.Entities
{
    public class Weapon : BaseEntity
    {
        public string WeaponName { get; set; }
        public decimal Length { get; set; }
        public decimal Weight { get; set; }
        public int NumberOfCandidate { get; set; }
        public int MedicalTestLevel { get; set; }
    }
}
