using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bidder.DashBoard.Helpers
{
    public class Authentication
    {
        public bool Authenticated { get; set; }
        public string ReturnMessage { get; set; }
        public string ReturnPage { get; set; }
        public int LoginCount { get; set; }
    }
}
