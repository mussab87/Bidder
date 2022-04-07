using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities;

namespace Bidder.Data.Specifications
{
    public class RolePermissionSpecification : BaseSpecification<Role>
    {
        public RolePermissionSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.RolePermissions);
        }
    }
}