using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using AmakenRES.Helpers;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;
using Bidder.Data.HelpersAttributes;
using Bidder.Data.Interfaces;
using Bidder.Data.Specifications;

namespace Bidder.DashBoard.Helpers
{
    public class HelperMethods
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUnitOfWork _unitOfWork;

        public static int CreditAccepted = 1;
        public static int CreditRejected = 2;

        public HelperMethods(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public HelperMethods(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public UserInfo UserInfo
        {
            get
            {
                if (_contextAccessor.HttpContext.Session.Get("UserInfo") == null) return new UserInfo();

                var userInfo = new UserInfo
                {
                    UserID = Convert.ToInt32(_contextAccessor.HttpContext.Session.Get("UserID")),
                    UserName = _contextAccessor.HttpContext.Session.Get("UserName").ToString(),
                };
                return userInfo;
            }
        }

        public bool HasRole(int id, int roleId)
        {
            var spec = new UserRoleSpecification(id);
            var User = _unitOfWork.Repository<User>().GetEntityWithSpec(spec);

            if (User != null)
            {
                var role = User.UserRoles.FirstOrDefault(c => c.RoleId == roleId);
                if (role != null)
                {
                    return true;
                }
            }

            return false;
        }



        public bool InRole(string pageName, string actionName, int userId)
        {
            Debug.WriteLine("====>>> Controller : " + pageName + "===>> ACTION ===>>" + actionName + "===>> USER" +
                            userId);
            var result = false;
            var spec = new UserRoleSpecification(userId);
            var user = _unitOfWork.Repository<User>().GetEntityWithSpec(spec);
            if (user == null) return false;

            foreach (var r in user.UserRoles.ToList())
            {
                var roleSpec = new RolePermissionSpecification(r.RoleId);
                var role = _unitOfWork.Repository<Role>().GetEntityWithSpec(roleSpec);
                if (role != null)
                {
                    if (role.RolePermissions.Any())
                    {
                        var perms = role.RolePermissions;
                        foreach (var perm in perms)
                        {
                            var testPerm = _unitOfWork.Repository<Permission>().GetById(perm.PermissionId);
                            if (testPerm != null)
                            {
                                if (testPerm.Action.ToLower() == actionName.ToLower() &&
                                    testPerm.Controller.ToLower() == pageName.ToLower())
                                {
                                    Debug.Print("GRANTED ACCESS ENTER :: " + pageName + " :: ======  ::  " +
                                                actionName + " :: ======  ::");
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        Debug.Print("NO ROLES !!!");
                    }

                    Debug.Print("NOT ACCESS ENTER :: " + pageName + " :: ======  ::  " +
                                actionName + " :: ======  ::");
                    return false;
                }
            }

            Debug.WriteLine("====>>> Controller : " + pageName + "===>> ACTION ===>>" + actionName + "===>> USER" +
                            userId + "==>" + result);
            return result;
        }

    }
}