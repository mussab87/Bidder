using System;
using System.Collections.Generic;
using System.Text;

namespace Bidder.Data.Entities
{
    public class RolePermission : BaseEntity
    {
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public Permission Permission { get; set; }
        public int PermissionId { get; set; }
    }
}
