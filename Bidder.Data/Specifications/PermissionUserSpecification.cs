using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities;

namespace Bidder.Data.Specifications
{
    public class PermissionUserSpecification :BaseSpecification<Permission>
    {
        public PermissionUserSpecification(bool isAdmin,bool isCustomer,bool isSupplier,bool isEmployee) : base(x=>x.IsAdmin == isAdmin
        || x.IsCustomer == isCustomer
        || x.IsEmployee == isEmployee
        || x.IsSupplier == isSupplier
        )
        {
            
        }
    }
}
