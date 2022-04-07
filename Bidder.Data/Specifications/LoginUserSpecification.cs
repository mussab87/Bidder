using System;
using System.Collections.Generic;
using System.Text;
using Bidder.Data.Entities.Account;

namespace Bidder.Data.Specifications
{
    public class LoginUserSpecification : BaseSpecification<User>
    {
        public LoginUserSpecification(UserParams userParams) : base(x =>
            x.UserName == userParams.Username && x.Password == userParams.Password)
        {
        }
    }
}