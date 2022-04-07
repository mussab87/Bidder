using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bidder.Business.Data;
using Bidder.Data.Entities;
using Bidder.DashBoard.Dtos;

namespace Bidder.DashBoard.Controllers
{
    public class StudentsController : Controller
    {
        private readonly BidderDataContext _context;

        public StudentsController(BidderDataContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RegistrationNumber,CandidatName,Cin,Weight,Length,MedicalTestLevel,Id,CreatedBy,CreatedDate,LastModifiedBy,LastModifiedDate,IsDeleted")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RegistrationNumber,CandidatName,Cin,Weight,Length,MedicalTestLevel,Id,CreatedBy,CreatedDate,LastModifiedBy,LastModifiedDate,IsDeleted")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }

        public IActionResult GenerateGroups()
        {
            var students = _context.Students.OrderBy(x => x.MedicalTestLevel).ToList();
            var weapons = _context.Weapons.OrderBy(x => x.MedicalTestLevel).ToList();
            var classifiedStudent = new List<ClassifiedStudent>();
            foreach (var weapon in weapons)
            {
                var counter = 0;
                foreach (var student in students)
                {
                    if (student.Weight >= weapon.Weight && student.Length >= weapon.Length && student.MedicalTestLevel == weapon.MedicalTestLevel)
                    {
                        var tmp = new ClassifiedStudent
                        {
                            WeaponId = weapon.Id,
                            StudentId = student.Id
                        };
                        var exist = classifiedStudent.FirstOrDefault(x => x.StudentId == student.Id);
                        if (exist == null)
                        {
                            classifiedStudent.Add(tmp);
                            //students.Remove(student);
                        }
                    }
                    counter++;
                }
            }
            var result = new List<StudentDtos>();
            foreach (var item in classifiedStudent)
            {
                var student = _context.Students.FirstOrDefault(x=>x.Id==item.StudentId);
                var weapon = _context.Weapons.FirstOrDefault(x => x.Id == item.WeaponId);
                var tmp = new StudentDtos
                {
                    RegistrationNumber = student.RegistrationNumber,
                    CandidatName = student.CandidatName,
                    Cin = student.Cin,
                    Weight = student.Weight,
                    Length = student.Length,
                    MedicalTestLevel = student.MedicalTestLevel,
                    Weapon =weapon.WeaponName,
                };
                result.Add(tmp);
            }
            return View(result);
        }
    }
}
