using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Bidder.Data.Entities
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }=DateTime.Now;
        public int LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }=DateTime.Now;
        public bool IsDeleted { get; set; } = false;

    }
}
