using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bidder.DashBoard.Filters;
using Bidder.DashBoard.ViewModels;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;
using Bidder.Data.Interfaces;
using Bidder.Data.Specifications;
using Bidder.DashBoard.Helpers;
using Bidder.Data.HelpersAttributes;

namespace Bidder.DashBoard.Controllers
{
    [ViewAuthorization]
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;


        public RoleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
       
        }

        public IActionResult Index()
        {

           
   
                var roles = _unitOfWork.Repository<Role>().ListAll();
   
                return View(roles);
        

        }

        // GET: role/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Role role)
        {
            if (ModelState.IsValid)
            {
                role.CreatedDate = DateTime.Now;
                role.LastModifiedDate = DateTime.Now;
                role.IsDeleted = false;
                role.CreatedBy = (int) HttpContext.Session.GetInt32("UserID");
                role.LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID");
                var user = _unitOfWork.Repository<User>().GetById(role.CreatedBy);
     
                _unitOfWork.Repository<Role>().Add(role);
                var result = -1;
                try
                {
                    result = _unitOfWork.Complete();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (result > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(role);
        }

        // GET: Permissions/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permission = _unitOfWork.Repository<Role>().GetById(id);
            if (permission == null)
            {
                return NotFound();
            }

            return View(permission);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Role Role)
        {
            if (id != Role.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Role.LastModifiedDate = DateTime.Now;
                    Role.LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID");
                    _unitOfWork.Repository<Role>().Update(Role);
                    _unitOfWork.Complete();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return RedirectToAction(nameof(Index));
            }

            return View(Role);
        }

        // GET: Permissions/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permission = _unitOfWork.Repository<Role>().GetById(id);

            if (permission == null)
            {
                return NotFound();
            }

            return View(permission);
        }

        [HttpPost]
        public IActionResult Delete(int id, int x = 1)
        {
            var permission = _unitOfWork.Repository<Role>().GetById(id);
            permission.IsDeleted = true;
            permission.LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID");
            permission.LastModifiedDate = DateTime.Now;
            _unitOfWork.Repository<Role>().Update(permission);
            _unitOfWork.Complete();

            return RedirectToAction(nameof(Index));
        }


        public ActionResult AddRole(int id)
        {
            var userId = (int) HttpContext.Session.GetInt32("UserID");
            var user = _unitOfWork.Repository<User>().GetById(userId);
            var spec = new RolesUsersSpecification(id);
            List<User> getListUser = new List<User>();
            List<User> noListUser = new List<User>();
            var roles = _unitOfWork.Repository<Role>().GetEntityWithSpec(spec);
            List<User> users = new List<User>();
           
            if (users.Any())
            {
                if (roles.UserRoles.Count == 0)
                {
                    noListUser = users.ToList();
                }
                else
                {
                    foreach (var usr in users)
                    {
                        // To avoid if employee of admin or supplier doesn't have user yet
                        if (usr != null)
                        {
                            var tempUser = roles.UserRoles.FirstOrDefault(x => x.UserId == usr.Id);
                            if (tempUser == null)
                            {
                                noListUser.Add(usr);
                            }
                            else
                            {
                                getListUser.Add(usr);
                            }
                        }
                    }
                }
            }

            var viewModel = new RoleAccountViewModel
            {
                RoleId = id,
                Roles = roles,
                Users = users.ToList(),
                GetRoleUser = getListUser,
                NoRoleUser = noListUser
            };
            return View(viewModel);
        }

        public ActionResult SaveUserRole(int roleId, List<int> accountIds)
        {
            List<User> getListUser = new List<User>();
            var createdBy = (int) HttpContext.Session.GetInt32("UserID");
            var spec = new RolesUsersSpecification(roleId);
            var roles = _unitOfWork.Repository<Role>().GetEntityWithSpec(spec);
            if (roles != null)
            {
                var users = _unitOfWork.Repository<User>().ListAll().ToList();

                foreach (var usr in users)
                {
                    var tempUser = roles.UserRoles.FirstOrDefault(x => x.UserId == usr.Id);
                    if (tempUser != null)
                    {
                        roles.UserRoles.Remove(tempUser);
                    }
                }

                _unitOfWork.Complete();


                foreach (var accountId in accountIds)
                {
                    var specId = new UserRoleSpecification(accountId);
                    var userId = _unitOfWork.Repository<User>().GetEntityWithSpec(specId);
                    if (userId == null)
                    {
                        return RedirectToAction("AddRole", "Role");
                    }

                    var userrolesp = new UserRoles()
                    {
                        UserId = accountId,
                        RoleId = roleId,
                        CreatedBy = (int) HttpContext.Session.GetInt32("UserID"),
                        CreatedDate = DateTime.Now,
                        LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID"),
                        LastModifiedDate = DateTime.Now,
                        IsDeleted = false
                    };
                    _unitOfWork.Repository<UserRoles>().Add(userrolesp);
                }
            }

            _unitOfWork.Complete();

            return RedirectToAction("Index", "Role");
        }
    }
}