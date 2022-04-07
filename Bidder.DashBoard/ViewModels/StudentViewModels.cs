using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bidder.DashBoard.ViewModels
{
    public class StudentViewModels
    {
        [Required(ErrorMessage = "Required")]
        [Display(Name = "رقم التسجيل")]
        public string RegistrationNumber { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "إسم المتقدم")]
        public string CandidatName { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "الهوية الوطنية")]
        public string Cin { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name =  "الوزن")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "الطول")]
        public decimal Length { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "مستوى الفحص الطبي")]
        public int MedicalTestLevel { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "الإحتياج")]
        public int NumberOfCandidate { get; set; }
        
    }
}
