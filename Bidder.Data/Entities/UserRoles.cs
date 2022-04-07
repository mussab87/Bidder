using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Bidder.Data.Entities.Account;

namespace Bidder.Data.Entities
{
    public class UserRoles : BaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
