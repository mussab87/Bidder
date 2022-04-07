using Bidder.Business.Data;
using Bidder.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace AmakenRES.Helpers
{
    public class EmailSettings
    {
        private readonly BidderDataContext _context;
        public EmailSettings(BidderDataContext context)
        {
            _context = context;
        }
    }
}