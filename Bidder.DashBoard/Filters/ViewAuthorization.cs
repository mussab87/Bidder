using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Bidder.DashBoard.Models;
using Bidder.Data.Interfaces;

namespace Bidder.DashBoard.Filters
{
    public class ViewAuthorization : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var logged = new LoggedUser();
            var _unitOfWork = context.HttpContext.RequestServices.GetService<IUnitOfWork>();
            int? tmpId = context.HttpContext.Session.GetInt32("UserID");
            int userId = tmpId ?? 0;
            var routeValue = context.ActionDescriptor.DisplayName.Trim().ToLower();
            var tmpArr = routeValue.Split(new[] {"."}, StringSplitOptions.RemoveEmptyEntries);
            var controllerName = tmpArr[3];
            var tmp = tmpArr[4];
            var actionName = tmp.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[0];
            Debug.Write("\n ----CONTROLLER--->" + controllerName + "--Action-->" + actionName + "\n");

            if (userId == 0)
            {
                context.Result = new RedirectResult("/Account/Login", false);
            }
            else
            {
                if (!logged.InRole(controllerName, actionName, userId, _unitOfWork))
                {
                    context.Result = new RedirectResult("/Error/Index", false);
                }
            }

            Debug.Write(MethodBase.GetCurrentMethod(), context.HttpContext.Request.Path);
        }
    }
}