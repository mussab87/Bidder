using System;
using System.Collections.Generic;
using System.Text;

namespace Bidder.Data.Entities
{
    public class ClassifiedStudent : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int WeaponId { get; set; }
        public Weapon Weapon { get; set; }
    }
}
