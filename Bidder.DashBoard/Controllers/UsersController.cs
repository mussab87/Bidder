using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bidder.Business.Data;
using Bidder.DashBoard.Helpers;
using Bidder.DashBoard.ViewModels;
using Bidder.Data.Entities.Account;

namespace Bidder.DashBoard.Controllers
{
    public class UsersController : Controller
    {
        private readonly BidderDataContext _context;

        public UsersController(BidderDataContext context)
        {
            _context = context;
        }

        // GET: Users
        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("UserID");
            var user = _context.User.FirstOrDefault(p => p.Id == userId);
            List<UsersViewModels> models = new List<UsersViewModels>();
            return View(models.ToList());
        }



        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.User.FindAsync(id);
            UsersViewModels obj = new UsersViewModels
            {
                Id = item.Id,
                Email = item.Email,
                UserName = item.UserName,
                NameInArabic = item.NameInArabic,
                NameInEnglish = item.NameInEnglish,
                //Password = item.Password,
                InActive = item.InActive
            };
            if (item == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, UsersViewModels user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var item = await _context.User.FindAsync(id);
                    var encryptPassword = Cryptography.EncryptPassword(user.Password, null);

                    item.NameInArabic = user.NameInArabic;
                    item.NameInEnglish = user.NameInEnglish;
                    if (user.Password != null)
                    {
                        item.Password = encryptPassword;
                    }
                    item.InActive = user.InActive;
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }


        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
    }
}
