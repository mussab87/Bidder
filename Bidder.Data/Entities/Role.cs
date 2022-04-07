using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bidder.Data.Entities.Account;

namespace Bidder.Data.Entities
{
    public class Role : BaseEntity
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsCustomer { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsSupplier { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
        public List<UserRoles> UserRoles { get; set; }
    }
}
