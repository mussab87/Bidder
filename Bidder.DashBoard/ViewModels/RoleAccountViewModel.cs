using Bidder.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bidder.Data.Entities.Account;

namespace Bidder.DashBoard.ViewModels
{
    public class RoleAccountViewModel
    {
        public Role Roles { get; set; }
      
        public IReadOnlyList<User> Users { get; set; }
        public IReadOnlyList<User> GetRoleUser { get; set; }
        public IReadOnlyList<User> NoRoleUser { get; set; }
        public IReadOnlyList<Permission> GetPermissions { get; set; }
        public IReadOnlyList<Permission> noGetPermissions { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }
    }
}
