using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;

namespace Bidder.Data.Specifications
{
    public class RolesUsersSpecification : BaseSpecification<Role>
    {
        public RolesUsersSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.UserRoles);
            AddInclude(c => c.RolePermissions);
        }
    }
}