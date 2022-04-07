using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bidder.Business.Data;
using Bidder.DashBoard.Filters;
using Bidder.DashBoard.Helpers;
using Bidder.DashBoard.ViewModels;
using Bidder.Data.Entities;
using Bidder.Data.Entities.Account;
using Bidder.Data.HelpersAttributes;
using Bidder.Data.Interfaces;
using Bidder.Data.Specifications;

namespace Bidder.DashBoard.Controllers
{
    [ViewAuthorization]
    public class PermissionsController : Controller
    {
        private readonly BidderDataContext _context;
        private readonly IUnitOfWork _unitOfWork;


        public PermissionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
    
        }

        // GET: Permissions
        public IActionResult Index()
        { 
            var permissions = _unitOfWork.Repository<Permission>().ListAll();
            return View(permissions);
        }

        public IActionResult AddPermission(int id)
        {
            var createdBy = (int) HttpContext.Session.GetInt32("UserID");
            var user = _unitOfWork.Repository<User>().GetById(createdBy);
            var spec = new RolesUsersSpecification(id);
            List<Permission> getPermissions = new List<Permission>();
            List<Permission> noGetPermissions = new List<Permission>();
            var permission = _unitOfWork.Repository<Role>().GetEntityWithSpec(spec);
            var permissions = _unitOfWork.Repository<Permission>().ListAll();
           
            if (permission == null)
            {
                noGetPermissions = permissions.ToList();
            }
            else
            {
                foreach (var item in permissions)
                {
                    var tempUser = permission.RolePermissions.FirstOrDefault(x => x.PermissionId == item.Id);
                    if (tempUser == null)
                    {
                        noGetPermissions.Add(item);
                    }
                    else
                    {
                        getPermissions.Add(item);
                    }
                }
            }

            var roles = _unitOfWork.Repository<Role>().GetById(id);
            var viewModel = new RoleAccountViewModel
            {
                Roles = roles,
                RoleId = id,
                GetPermissions = getPermissions,
                noGetPermissions = noGetPermissions
            };
            return View(viewModel);
        }

        //SaveRolePermission
        [HttpPost]
        public IActionResult SaveRolePermission(int roleId, List<int> permissionIds)
        {
            var createdBy = (int) HttpContext.Session.GetInt32("UserID");
            var user = _unitOfWork.Repository<User>().GetById(createdBy);

            var spec = new RolesUsersSpecification(roleId);
            var role = _unitOfWork.Repository<Role>().GetEntityWithSpec(spec);
            if (role != null)
            {
                role.RolePermissions.Clear();
                if (user != null)
                {
                    foreach (var permissionId in permissionIds)
                    {
                        var permissionInDb = _unitOfWork.Repository<Permission>().GetById(permissionId);
                        if (permissionInDb == null)
                        {
                            return RedirectToAction("AddPermission", "Permissions");
                        }

                        var rolePermission = new RolePermission
                        {
                            PermissionId = permissionInDb.Id,
                            RoleId = roleId,
                            CreatedBy = user.Id,
                            CreatedDate = DateTime.Now,
                            LastModifiedBy = user.Id,
                            LastModifiedDate = DateTime.Now,
                            IsDeleted = false
                        };
                        role.RolePermissions.Add(rolePermission);
                    }
                }
            }

            _unitOfWork.Repository<Role>().Update(role);
            try
            {
                var result = _unitOfWork.Complete();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


            return RedirectToAction("Index", "Role");
        }

        // GET: Permissions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Permissions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create(Permission permission)
        {
            if (ModelState.IsValid)
            {
                permission.CreatedDate = DateTime.Now;
                permission.LastModifiedDate = DateTime.Now;
                permission.IsDeleted = false;
                permission.CreatedBy = (int) HttpContext.Session.GetInt32("UserID");
                permission.LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID");
                permission.Controller = permission.Controller.ToLower();
                permission.Action = permission.Action.ToLower();
                _unitOfWork.Repository<Permission>().Add(permission);
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

            return View(permission);
        }

        // GET: Permissions/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permission = _unitOfWork.Repository<Permission>().GetById(id);
            if (permission == null)
            {
                return NotFound();
            }

            return View(permission);
        }

        // POST: Permissions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Permission permission)
        {
            if (id != permission.Id)
            {
                return NotFound();
            }

            var permissionInDb = _unitOfWork.Repository<Permission>().GetById(id);
            if (ModelState.IsValid)
            {
                try
                {
                    permissionInDb.LastModifiedDate = DateTime.Now;
                    permissionInDb.LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID");
                    permissionInDb.IsCustomer = permission.IsCustomer;
                    permissionInDb.IsAdmin = permission.IsAdmin;
                    permissionInDb.IsSupplier = permission.IsSupplier;
                    permissionInDb.IsEmployee = permission.IsEmployee;
                    _unitOfWork.Repository<Permission>().Update(permissionInDb);
                    _unitOfWork.Complete();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return RedirectToAction(nameof(Index));
            }

            return View(permission);
        }

        // GET: Permissions/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var permission = _unitOfWork.Repository<Permission>().GetById(id);

            if (permission == null)
            {
                return NotFound();
            }

            return View(permission);
        }

        // POST: Permissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, int x = 1)
        {
            var permission = _unitOfWork.Repository<Permission>().GetById(id);
            permission.IsDeleted = true;
            permission.LastModifiedBy = (int) HttpContext.Session.GetInt32("UserID");
            permission.LastModifiedDate = DateTime.Now;
            _unitOfWork.Repository<Permission>().Update(permission);
            _unitOfWork.Complete();

            return RedirectToAction(nameof(Index));
        }

        private bool PermissionExists(int id)
        {
            return _context.Permissions.Any(e => e.Id == id);
        }

        public ActionResult GetAllControllerActionsUpdated()
        {
            var asm = Assembly.GetExecutingAssembly();

            var controlleractionlist = asm.GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type))
                .SelectMany(type =>
                    type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                .Where(m => !m.GetCustomAttributes(typeof(CompilerGeneratedAttribute),
                    true).Any())
                .Select(x => new
                {
                    Controller = x.DeclaringType.Name,
                    Action = x.Name,
                    ReturnType = x.ReturnType.Name,
                    Attributes = string.Join(",",
                        x.GetCustomAttributes().Select(a => a.GetType().Name.Replace("Attribute", "")))
                })
                .OrderBy(x => x.Controller).ThenBy(x => x.Action).ToList();
            var list = new List<ControllerActions>();
            var currentUser = 1;
            var userId = HttpContext.Session.GetInt32("UserID");
            if (userId != null)
            {
                currentUser = (int) userId;
            }

            var allPermissions = _unitOfWork.Repository<Permission>().ListAll();
            foreach (var item in controlleractionlist)
            {
                var permission = new Permission
                {
                    Action = item.Action,
                    CreatedBy = currentUser,
                    LastModifiedBy = currentUser,
                    Controller = item.Controller,
                    NameAr = item.Action + "-" + item.Controller,
                    NameEn = item.Action + "-" + item.Controller,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now,
                    IsAdmin = true
                };


                var _tempPer = allPermissions.FirstOrDefault(x =>
                    x.Action.ToLower() == item.Action.ToLower() && x.Controller.ToLower() == item.Controller.ToLower());
                if (_tempPer == null)
                {
                    _unitOfWork.Repository<Permission>().Add(permission);
                    try
                    {
                        _unitOfWork.Complete();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }

    public class ControllerActions
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Attributes { get; set; }
        public string ReturnType { get; set; }
    }
}