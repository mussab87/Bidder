using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities;

namespace Bidder.Data.Specifications
{
    public class PermissionSpecification : BaseSpecification<Permission>
    {
        public PermissionSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(c=>c.RolePermissions);
        }
    }
}