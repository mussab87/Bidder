using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Bidder.Data.Entities;

namespace Bidder.DashBoard.ViewModels
{
    public class UsersViewModels
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "NameInArabic")]
        public string NameInArabic { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "NameInEnglish")]
        public string NameInEnglish { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "InActive")]
        public bool InActive { get; set; }
        public string Address { get; set; }
        public int Logins { get; set; }
        public DateTime LastLogin { get; set; }
        public List<UserRoles> UserRoles { get; set; }
    }
}
