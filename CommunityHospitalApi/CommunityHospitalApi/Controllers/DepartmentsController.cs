using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;
using CommunityHospitalApi.Attributes;

namespace CommunityHospitalApi.Controllers
{
    [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : Controller
    {
        private readonly CommunityHospitalDbContext _context;

        public DepartmentsController(CommunityHospitalDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// List of departments
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetDepartments()
        {
            return Ok(await _context.Departments.ToListAsync());
        }

        /// <summary>
        /// Get a department
        /// </summary>
        /// <param name="id">Department id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(Guid id)
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

        /// <summary>
        /// Create department
        /// </summary>
        /// <param name="department">Department object</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateDepartment([Bind("DepartmentName,ManagerFirstName,ManagerLastName,DateCreated")] Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            department.DepartmentId = Guid.NewGuid();
            _context.Add(department);
            await _context.SaveChangesAsync();
            return Ok(department);

        }


        /// <summary>
        /// Edit department
        /// </summary>
        /// <param name="id">Department id</param>
        /// <param name="department">Department object</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> EditDepartment(Guid id, [Bind("DepartmentName,ManagerFirstName,ManagerLastName")] Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!_context.Departments.Any(d => d.DepartmentId == id))
            {
                return NotFound();
            }
            
                 department.DepartmentId = id;
                _context.Update(department);
                await _context.SaveChangesAsync();


            return Ok(department);
        }

        /// <summary>
        /// Delete department
        /// </summary>
        /// <param name="id">Department id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment( Guid id)
        {
            var department = await _context.Departments.FindAsync(id);

            if (department == null)
            {
                return NotFound();
            }
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return Ok(department);
        }
    }
}
