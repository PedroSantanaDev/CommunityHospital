using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

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

        /// <summary>
        /// List of departments
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        [HttpGet("{apiKey}")]
        public async Task<IActionResult> GetDepartments(string apiKey)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

            return Ok(await _context.Departments.ToListAsync());
        }

        /// <summary>
        /// Get a department
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{apiKey}/{id}")]
        public async Task<IActionResult> GetDepartment(string apiKey, Guid? id)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

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
        /// <param name="apiKey"></param>
        /// <param name="department"></param>
        /// <returns></returns>
        [HttpPost("{apiKey}")]
        public async Task<IActionResult> CreateDepartment(string apiKey, [Bind("DepartmentName,ManagerFirstName,ManagerLastName,DateCreated")] Department department)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

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
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <param name="department"></param>
        /// <returns></returns>
        [HttpPut("{apiKey}/{id}")]
        public async Task<IActionResult> EditDepartment(string apiKey, Guid id, [Bind("DepartmentName,ManagerFirstName,ManagerLastName")] Department department)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

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
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{apiKey}/{id}")]
        public async Task<IActionResult> DeleteDepartment(string apiKey, Guid id)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

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
