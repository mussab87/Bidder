using System;
using System.Collections.Generic;
using System.Text;

namespace Bidder.Data.Entities
{
    public class Permission : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsSupplier { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}