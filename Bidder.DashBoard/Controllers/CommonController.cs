using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;

namespace Bidder.DashBoard.Controllers
{
    public class CommonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(20) }
                );
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddDays(20);
            Response.Cookies.Append("culture", culture, option);
            Response.Cookies.Append("lang", culture, option);
            return Json(returnUrl);
        }

        public NoContentResult ClearMessage()
        {
            HttpContext.Session.SetString("Message", "");
            return NoContent();
        }

       

    }
}
