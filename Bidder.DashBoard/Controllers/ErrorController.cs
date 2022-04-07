using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bidder.DashBoard.Filters;

namespace Bidder.DashBoard.Controllers
{
    
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
