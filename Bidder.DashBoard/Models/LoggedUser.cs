using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bidder.Business.Data;
using Bidder.DashBoard.Helpers;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;
using Bidder.Data.Interfaces;
using Bidder.Data.Specifications;

namespace Bidder.DashBoard.Models
{
    public class LoggedUser
    {
        public LoggedUser()
        {
        }

        public bool InRole(string pageName, string actionName, int userId, IUnitOfWork _unitOfWork)
        {
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
                                if (testPerm.Action.ToLower() == actionName.ToLower() && testPerm.Controller.ToLower() == pageName.ToLower())
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

            return result;
        }
    }
}