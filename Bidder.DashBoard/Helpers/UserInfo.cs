using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace AmakenRES.Helpers
{
    public  class UserInfo
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string NationalId { get; set; }
        public string CompanyID { get; set; }
        public  int WYear { get; set; }
        public  int WorkingDate { get; set; }
        public  int DefaultLanguage { get; set; }
        public  string UserDescription { get; set; }
        public  string EngDescription { get; set; }
        public  bool PDefaultLanguage { get; set; }
        public  string CompanyDescription { get; set; }
        public  int iStartWorkingDate { get;  set; }
        public  int iEndWorkingDate { get;  set; }
        public  bool IsCurrentYear { get;  set; }
        public  short YearStatus { get;  set; }
        public  string ConnectionString { get; set; }

	
	}
 

}