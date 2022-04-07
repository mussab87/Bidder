using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities.Account;

namespace Bidder.Data.Specifications
{
    public class UserRoleSpecification : BaseSpecification<User>
    {
        public UserRoleSpecification(int id) : base(x=>x.Id == id)
        {
            AddInclude(x=>x.UserRoles);
        }
    }
}
