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
    public class PatientsController : Controller
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;
        public PatientsController(IPatientService patientService, IMapper mapper)
        {
            _patientService = patientService;
            _mapper = mapper;
        }
        /// <summary>
        /// List of patients
        /// </summary>
        /// <returns>List of patients</returns>
        [HttpGet("")]
        public async Task<IActionResult> GetPatients()
        {
            var patients = await _patientService.GetAllPatients();

            var patientResources = _mapper.Map<IEnumerable<Patient>, IEnumerable<PatientResource>>(patients);

            return Ok(patientResources);
        }

        /// <summary>
        /// Get patient
        /// </summary>
        /// <param name="id">Patient id</param>
        /// <returns>Patient</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(Guid id)
        {
            var patient = await _patientService.GetPatientById(id);

            if(patient == null)
            {
                return NotFound();
            }

            var patientResource = _mapper.Map<Patient, PatientResource>(patient);

            return Ok(patientResource);
        }

        /// <summary>
        /// Create patients
        /// </summary>
        /// <param name="savePatientResource"></param>
        /// <returns>Newly created patient</returns>
        [HttpPost("")]
        public async Task<ActionResult<PatientResource>> CreatePatient([FromBody] SavePatientResource savePatientResource)
        {
            var validator = new SavePatientResourceValidator();

            var validationResult = await validator.ValidateAsync(savePatientResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var patientToCreate = _mapper.Map<SavePatientResource, Patient>(savePatientResource);

            var newPatient = await _patientService.CreatePatient(patientToCreate);

            var patient = await _patientService.GetPatientById(newPatient.PatientId);

            var patientResource = _mapper.Map<Patient, PatientResource>(patient);

            return Ok(patientResource);
        }

        /// <summary>
        /// Edit patient
        /// </summary>
        /// <param name="id">Patient id</param>
        /// <param name="savePatientResource"></param>
        /// <returns>Newly editted patient</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<PatientResource>> EditPatient(Guid id, [FromBody] SavePatientResource savePatientResource)
        {
            var validator = new SavePatientResourceValidator();

            var validationResult = await validator.ValidateAsync(savePatientResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var patientToBeUpdated = await _patientService.GetPatientById(id);

            if (patientToBeUpdated == null)
            {
                return NotFound();
            }

            var patient = _mapper.Map<SavePatientResource, Patient>(savePatientResource);

            await _patientService.UpdatePatient(patientToBeUpdated, patient);

            var updatedPatient = await _patientService.GetPatientById(id);

            var updatedPatientResource = _mapper.Map<Patient, PatientResource>(updatedPatient);

            return Ok(updatedPatientResource);

        }
        /// <summary>
        /// Delete patient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(Guid id)
        {
            var patient = await _patientService.GetPatientById(id);

            if (patient == null)
            {
                return NotFound();
            }

            await _patientService.DeletePatient(patient);

            return Ok("Patient deleted.");
        }

    }
}
