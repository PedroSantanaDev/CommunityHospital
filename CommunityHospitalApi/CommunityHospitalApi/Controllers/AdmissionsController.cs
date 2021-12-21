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
    public class AdmissionsController : Controller
    {
        private readonly IAdmissionService _admissionService;
        private readonly IMapper _mapper;
        public AdmissionsController(IAdmissionService vendorService, IMapper mapper)
        {
            _admissionService = vendorService;
            _mapper = mapper;
        }
        /// <summary>
        /// Get all admissions
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetAdmissions()
        {
            var admissions = await _admissionService.GetAllAdmissions();

            var admissionResources = _mapper.Map<IEnumerable<Admission>, IEnumerable<AdmissionResource>>(admissions);

            return Ok(admissionResources);
        }

        /// <summary>
        /// Get admission
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdmission(Guid id)
        {
            var admission = await _admissionService.GetAdmissionById(id);

            if (admission == null)
            {
                return NotFound();
            }

            var admissionResource = _mapper.Map<Admission, AdmissionResource>(admission);

            return Ok(admissionResource);
        }

        /// <summary>
        /// Create admission
        /// </summary>
        /// <param name="saveAdmissionResource"></param>
        /// <returns>Newly created admission</returns>
        [HttpPost("")]
        public async Task<ActionResult<AdmissionResource>> CreateAdmission([FromBody] SaveAdmissionResource saveAdmissionResource)
        {
            var validator = new SaveAdmissionResourceValidator();

            var validationResult = await validator.ValidateAsync(saveAdmissionResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var admissionToCreate = _mapper.Map<SaveAdmissionResource, Admission>(saveAdmissionResource);

            var newAdmission = await _admissionService.CreateAdmission(admissionToCreate);

            var admission = await _admissionService.GetAdmissionById(newAdmission.AdmissionId);

            var admissionResource = _mapper.Map<Admission, AdmissionResource>(admission);

            return Ok(admissionResource);
        }

        /// <summary>
        /// Edit admission
        /// </summary>
        /// <param name="id">Admission id</param>
        /// <param name="saveAdmissionResource"></param>
        /// <returns>Newly updated admission</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<AdmissionResource>> EditAdmission(Guid id, [FromBody] SaveAdmissionResource saveAdmissionResource)
        {
            var validator = new SaveAdmissionResourceValidator();

            var validationResult = await validator.ValidateAsync(saveAdmissionResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var admissionToBeUpdated = await _admissionService.GetAdmissionById(id);

            if (admissionToBeUpdated == null)
            {
                return NotFound();
            }

            var admission = _mapper.Map<SaveAdmissionResource, Admission>(saveAdmissionResource);

            await _admissionService.UpdateAdmission(admissionToBeUpdated, admission);

            var updatedAdmission = await _admissionService.GetAdmissionById(id);

            var updatedAdmissionResource = _mapper.Map<Admission, AdmissionResource>(updatedAdmission);

            return Ok(updatedAdmissionResource);
        }
        /// <summary>
        /// Get admission
        /// </summary>
        /// <param name="id">Admission id</param>
        /// <returns>admission</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdmission(Guid id)
        {
            var admission = await _admissionService.GetAdmissionById(id);

            if (admission == null)
            {
                return NotFound();
            }

            await _admissionService.DeleteAdmission(admission);

            return Ok("Admission deleted.");
        }
    }
}
