using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bidder.Business.Data;
using Bidder.Data.Entities;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Text;
using Bidder.DashBoard.ViewModels;

namespace Bidder.DashBoard.Controllers
{
    public class WeaponsController : Controller
    {
        private readonly BidderDataContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        public WeaponsController(BidderDataContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Weapons
        public async Task<IActionResult> Index()
        {
            return View(await _context.Weapons.ToListAsync());
        }


        
        // GET: Weapons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weapon == null)
            {
                return NotFound();
            }

            return View(weapon);
        }

        // GET: Weapons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Weapons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WeaponName,Length,Weight,MedicalTestLevel,Id,CreatedBy,CreatedDate,LastModifiedBy,LastModifiedDate,IsDeleted,NumberOfCandidate")] Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weapon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weapon);
        }

        // GET: Weapons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapons.FindAsync(id);
            if (weapon == null)
            {
                return NotFound();
            }
            return View(weapon);
        }

        // POST: Weapons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WeaponName,Length,Weight,MedicalTestLevel,Id,CreatedBy,CreatedDate,LastModifiedBy,LastModifiedDate,IsDeleted,NumberOfCandidate")] Weapon weapon)
        {
            if (id != weapon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weapon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeaponExists(weapon.Id))
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
            return View(weapon);
        }

        // GET: Weapons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weapon = await _context.Weapons
                .FirstOrDefaultAsync(m => m.Id == id);
            if (weapon == null)
            {
                return NotFound();
            }

            return View(weapon);
        }

        // POST: Weapons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);
            _context.Weapons.Remove(weapon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeaponExists(int id)
        {
            return _context.Weapons.Any(e => e.Id == id);
        }

        public IActionResult ImportStudents()
        {
            return View();
        }
        public ActionResult ImportFile()
        {
            return View();
        }

        public async Task<ActionResult> Upload()
        {
            IFormFile file = Request.Form.Files[0];
            string folderName = "UploadExcel";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            StringBuilder sb = new StringBuilder();
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            if (file.Length > 0)
            {
                string sFileExtension = Path.GetExtension(file.FileName).ToLower();
                ISheet sheet;
                string fullPath = Path.Combine(newPath, file.FileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                    stream.Position = 0;
                    if (sFileExtension == ".xls")
                    {
                        HSSFWorkbook hssfwb = new HSSFWorkbook(stream); //This will read the Excel 97-2000 formats  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook  
                    }
                    else
                    {
                        XSSFWorkbook hssfwb = new XSSFWorkbook(stream); //This will read 2007 Excel format  
                        sheet = hssfwb.GetSheetAt(0); //get first sheet from workbook   
                    }

                    IRow headerRow = sheet.GetRow(0); //Get Header Row
                    int cellCount = headerRow.LastCellNum;
                    sb.Append("<table class='table table-bordered' style='direction:rtl !important;border-color:#fff'><tr>");
                    for (int j = 0; j < cellCount; j++)
                    {
                        NPOI.SS.UserModel.ICell cell = headerRow.GetCell(j);
                        if (cell == null || string.IsNullOrWhiteSpace(cell.ToString())) continue;
                        sb.Append("<th>" + cell.ToString() + "</th>");
                    }

                    sb.Append("</tr>");
                    sb.AppendLine("<tr>");
                    for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++) //Read Excel File
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;
                        if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
                        var checkExcel = 0;
                        var colorReg = "green";
                        var colorCandidatName = "green";
                        var colorCin = "green";
                        var colorWeight = "green";
                        var colorLength = "green";
                        var colorMedicalTestLevel = "green";
                        if (String.IsNullOrEmpty(row.GetCell(0).ToString()))
                        {
                            checkExcel++;
                            colorReg = "red";
                        }
                        if (String.IsNullOrEmpty(row.GetCell(1).ToString()))
                        {
                            checkExcel++;
                            colorCandidatName = "red";
                        }
                        if (String.IsNullOrEmpty(row.GetCell(2).ToString()))
                        {
                            checkExcel++;
                            colorCin = "red";
                        }
                        if (Decimal.Parse(row.GetCell(3).ToString()) < 0 || Decimal.Parse(row.GetCell(3).ToString()) == 0)
                        {
                            checkExcel++;
                            colorWeight = "red";
                        }
                        if (Decimal.Parse(row.GetCell(4).ToString()) < 0 || Decimal.Parse(row.GetCell(4).ToString()) == 0)
                        {
                            checkExcel++;
                            colorLength = "red";
                        }
                        if (int.Parse(row.GetCell(5).ToString()) < 1 || int.Parse(row.GetCell(5).ToString()) > 3)
                        {
                            checkExcel++;
                            colorMedicalTestLevel = "red";
                        }
                        if (checkExcel == 0)
                        {
                            var student = new Student
                            {
                                RegistrationNumber = row.GetCell(0).ToString(),
                                CandidatName = row.GetCell(1).ToString(),
                                Cin = row.GetCell(2).ToString(),
                                Weight = Decimal.Parse(row.GetCell(3).ToString()),
                                Length = Decimal.Parse(row.GetCell(4).ToString()),
                                MedicalTestLevel = int.Parse(row.GetCell(5).ToString()),
                            };
                     
                            var result = -1;
                            try
                            {
                                _context.Add(student);
                                result= await _context.SaveChangesAsync();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
                        sb.Append("<td style='background-color:"+colorReg+"'>" + row.GetCell(0).ToString() + "</td>");
                        sb.Append("<td style='background-color:" + colorCandidatName + "'>" + row.GetCell(1).ToString() + "</td>");
                        sb.Append("<td style='background-color:" + colorCin + "'>" + row.GetCell(2).ToString() + "</td>");
                        sb.Append("<td style='background-color:" + colorWeight + "'>" + row.GetCell(3).ToString() + "</td>");
                        sb.Append("<td style='background-color:" + colorLength + "'>" + row.GetCell(4).ToString() + "</td>");
                        sb.Append("<td style='background-color:" + colorMedicalTestLevel + "'>" + row.GetCell(5).ToString() + "</td>");


                        sb.AppendLine("</tr>");
                    }

                    sb.Append("</table>");
                }
            }

            return this.Content(sb.ToString());
        }
    }
}
