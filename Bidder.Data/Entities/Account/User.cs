using System;
using System.Collections.Generic;
using System.Text;

namespace Bidder.Data.Entities.Account
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NameInArabic { get; set; }
        public string NameInEnglish { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public  bool InActive { get; set; }
        public string Address { get; set; }
        public int Logins { get; set; }
        public DateTime LastLogin { get; set; }
        public List<UserRoles> UserRoles { get; set; }
    }
}