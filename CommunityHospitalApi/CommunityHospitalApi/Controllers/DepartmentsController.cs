using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace CommunityHospitalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : Controller
    {
        private readonly CommunityHospitalDbContext _context;

        public DepartmentsController(CommunityHospitalDbContext context)
        {
            _context = context;
        }

        // GET: Departments
        [HttpGet("GetDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            return Ok(await _context.Departments.ToListAsync());
        }

        // GET: Departments/Details/5
        [HttpGet("GetDepartment")]
        public async Task<IActionResult> GetDepartment(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments
                .FirstOrDefaultAsync(m => m.DepartmentId == id);

            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        // GET: Departments/Create
        /*public IActionResult Create()
        {
            return View();
        }*/

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /* [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create([Bind("DepartmentId,DepartmentName,ManagerFirstName,ManagerLastName,DateCreated")] Department department)
         {
             if (ModelState.IsValid)
             {
                 department.DepartmentId = Guid.NewGuid();
                 _context.Add(department);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             return View(department);
         }*/

        // GET: Departments/Edit/5
        /*public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.FindAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }*/

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        /* [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit(Guid id, [Bind("DepartmentId,DepartmentName,ManagerFirstName,ManagerLastName,DateCreated")] Department department)
         {
             if (id != department.DepartmentId)
             {
                 return NotFound();
             }

             if (ModelState.IsValid)
             {
                 try
                 {
                     _context.Update(department);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!DepartmentExists(department.DepartmentId))
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
             return View(department);
         }*/

        // GET: Departments/Delete/5
        /* public async Task<IActionResult> Delete(Guid? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var department = await _context.Departments
                 .FirstOrDefaultAsync(m => m.DepartmentId == id);
             if (department == null)
             {
                 return NotFound();
             }

             return View(department);
         }*/

        // POST: Departments/Delete/5
        /*[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var department = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }*/

        /*private bool DepartmentExists(Guid id)
        {
            return _context.Departments.Any(e => e.DepartmentId == id);
        }*/
    }
}
