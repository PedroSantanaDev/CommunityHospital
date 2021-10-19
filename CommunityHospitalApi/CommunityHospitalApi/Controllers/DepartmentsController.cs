using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityHospitalApi.Models;
using CommunityHospitalApi.Attributes;
using CommunityHospitalApi.Services;
using AutoMapper;
using CommunityHospitalApi.Resources;
using System.Collections.Generic;
using CommunityHospitalApi.Validators;

namespace CommunityHospitalApi.Controllers
{
    [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;

        public DepartmentsController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }

        /// <summary>
        /// List of departments
        /// </summary>
        /// <returns>List of departments</returns>
        [HttpGet("")]
        public async Task<IActionResult> GetDepartments()
        {
            var departments = await _departmentService.GetAllDepartments();

            var departmentResources = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentResource>>(departments);

            return Ok(departmentResources);
        }

        /// <summary>
        /// Get a department
        /// </summary>
        /// <param name="id">Department id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartment(Guid id)
        {
            var department = await _departmentService.GetDepartmentById(id);
            
            if(department == null)
            {
                return NotFound();
            }

            var departmentResource = _mapper.Map<Department, DepartmentResource>(department);

            return Ok(departmentResource);
        }

        /// <summary>
        /// Create department
        /// </summary>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<DepartmentResource>> CreateDepartment([FromBody] SaveDepartmentResource saveDepartmentResource)
        {
            var validator = new SaveDepartmentResourceValidator();

            var validationResult = await validator.ValidateAsync(saveDepartmentResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors); 
            }
                
            var departmentToCreate = _mapper.Map<SaveDepartmentResource, Department>(saveDepartmentResource);

            var newDepartment = await _departmentService.CreateDepartment(departmentToCreate);

            var department = await _departmentService.GetDepartmentById(newDepartment.DepartmentId);

            var departmentResource = _mapper.Map<Department, DepartmentResource>(department);

            return Ok(departmentResource);
        }


        /// <summary>
        /// Edit department
        /// </summary>
        /// <param name="id">Department id</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<DepartmentResource>> EditDepartment(Guid id, [FromBody] SaveDepartmentResource saveDepartmentResource)
        {
            var validator = new SaveDepartmentResourceValidator();

            var validationResult = await validator.ValidateAsync(saveDepartmentResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var departmentToBeUpdate = await _departmentService.GetDepartmentById(id);

            if (departmentToBeUpdate == null)
            {
                return NotFound();
            }
               
            var department = _mapper.Map<SaveDepartmentResource, Department>(saveDepartmentResource);

            await _departmentService.UpdateDepartment(departmentToBeUpdate, department);

            var updatedDepartment = await _departmentService.GetDepartmentById(id);

            var updatedDepartmentResource = _mapper.Map<Department, DepartmentResource>(updatedDepartment);

            return Ok(updatedDepartmentResource);
        }

        /// <summary>
        /// Delete department
        /// </summary>
        /// <param name="id">Department id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(Guid id)
        {
            var department = await _departmentService.GetDepartmentById(id);

            if (department == null)
            {
                return NotFound();
            }
            
            await _departmentService.DeleteDepartment(department);

            return Ok("Department deleted.");
        }
    }
}
