using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities.Account;

namespace Bidder.Data.Specifications
{
    public class FindUserEmailOrUsernameSpecification : BaseSpecification<User>
    {
        public FindUserEmailOrUsernameSpecification(string username,string email) : base(x=>x.UserName == username || x.Email == email)
        {
            
        }
    }
}
