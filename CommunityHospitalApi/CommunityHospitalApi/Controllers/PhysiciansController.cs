using AutoMapper;
using CommunityHospitalApi.Attributes;
using CommunityHospitalApi.Models;
using CommunityHospitalApi.Resources;
using CommunityHospitalApi.Services;
using CommunityHospitalApi.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Controllers
{
    [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class PhysiciansController : Controller
    {
        private readonly IPhysicianService _physicianService;
        private readonly IMapper _mapper;

        public PhysiciansController(IPhysicianService physicianService, IMapper mapper)
        {
            _physicianService = physicianService;
            _mapper = mapper;
        }
        /// <summary>
        /// Get physicians
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetPhysicians()
        {
            var physicians = await _physicianService.GetAllPhysicians();

            var physiciansResources = _mapper.Map<IEnumerable<Physician>, IEnumerable<PhysicianResource>>(physicians);

            return Ok(physiciansResources);
        }
        /// <summary>
        /// Get a physician
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhysician(Guid id)
        {
            var physician = await _physicianService.GetPhysicianById(id);

            if(physician == null)
            {
                return NotFound();
            }

            var physicianResource = _mapper.Map<Physician, PhysicianResource>(physician);

            return Ok(physicianResource);
        }
        /// <summary>
        /// Create a physician
        /// </summary>
        /// <param name="savePhysicianResource"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<PhysicianResource>> CreatePhysician([FromBody] SavePhysicianResource savePhysicianResource)
        {
            var validator = new SavePhysicianResourceValidator();

            var validationResult = await validator.ValidateAsync(savePhysicianResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var physicianToCreate = _mapper.Map<SavePhysicianResource, Physician>(savePhysicianResource);

            var newPhysician = await _physicianService.CreatePhysician(physicianToCreate);

            var physician = await _physicianService.GetPhysicianById(newPhysician.PhysicianId);

            var physicianResource = _mapper.Map<Physician, PhysicianResource>(physician);

            return Ok(physicianResource);
        }
        /// <summary>
        /// Edit a physician
        /// </summary>
        /// <param name="id"></param>
        /// <param name="savePhysicianResource"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<PhysicianResource>> EditPhysician(Guid id, [FromBody] SavePhysicianResource savePhysicianResource)
        {
            var validator = new SavePhysicianResourceValidator();

            var validationResult = await validator.ValidateAsync(savePhysicianResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var physicianToBeUpdated = await _physicianService.GetPhysicianById(id);

            if(physicianToBeUpdated == null)
            {
                NotFound();
            }

            var physician = _mapper.Map<SavePhysicianResource, Physician>(savePhysicianResource);

            await _physicianService.UpdatePhysician(physicianToBeUpdated, physician);

            var updatedPhysician = await _physicianService.GetPhysicianById(id);

            var updatedPhysicianResource = _mapper.Map<Physician, PhysicianResource>(updatedPhysician);

            return Ok(updatedPhysicianResource);
        }
        /// <summary>
        /// Delete a physician
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhysician(Guid id)
        {
            var physician = await _physicianService.GetPhysicianById(id);

            if(physician == null)
            {
                return NotFound();
            }

            await _physicianService.DeletePhysician(physician);

            return Ok("Physician deleted.");
        }
    }
}
