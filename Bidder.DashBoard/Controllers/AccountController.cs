using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bidder.Business.Data;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;
using Bidder.Data.Interfaces;
using Bidder.Data.Specifications;
using Bidder.DashBoard.Helpers;

namespace Bidder.DashBoard.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<HomeController> _logger;

        public AccountController(IUnitOfWork unitOfWork, ILogger<HomeController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(User user)
        {
            AppResponse ret = new AppResponse();
            var message = default(string);
            try
            {
                var encryptPassword = Cryptography.EncryptPassword(user.Password, null);
                var userParams = new UserParams
                {
                    Username = user.UserName,
                    Password = encryptPassword
                };
                var spec = new LoginUserSpecification(userParams);
                var userInfo = _unitOfWork.Repository<User>().GetEntityWithSpec(spec);

                if (userInfo != null)
                {
                    if (!userInfo.InActive && userInfo.IsDeleted == false)
                    {
                        ret.Success = true;
                        ret.Message = "logged-in";
                        ret.Action = "/home";
                        HttpContext.Session.SetInt32("UserID", userInfo.Id);
                        HttpContext.Session.SetString("UserName", userInfo.UserName);
                        HttpContext.Session.SetString("Email", userInfo.Email);
                        HttpContext.Session.SetString("NameInArabic", userInfo.NameInArabic);
                        HttpContext.Session.SetString("NameInEnglish", userInfo.NameInEnglish);
                    }
           
                }
                else
                {
                    ModelState.AddModelError(string.Empty,
                        "The email address or password supplied are incorrect. Please check your spelling and try again.");
                }

                if (!ret.Success) //login was unsuccessful, return employee errors
                    ret.Message =
                        "The email address or password supplied are incorrect. Please check your spelling and try again.";
                string msg = $"login successfully {userInfo?.UserName} {DateTime.UtcNow.ToLongTimeString()}";
                _logger.LogInformation(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _logger.LogError(e.Message);
                throw;
            }



            return Json(ret);
        }


        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public class AppResponse
        {
            public bool Success { get; set; } = false;
            public string Message { get; set; } = "";
            public string Action { get; set; } = "";
        }
    }
}