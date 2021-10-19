using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;
using CommunityHospitalApi.Attributes;
using CommunityHospitalApi.Services;
using AutoMapper;
using System.Collections.Generic;
using CommunityHospitalApi.Resources;
using CommunityHospitalApi.Validators;

namespace CommunityHospitalApi.Controllers
{
    [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class MedicationsController : Controller
    {
        private readonly CommunityHospitalDbContext _context;
        private readonly IMedicationService _medicationService;
        private readonly IMapper _mapper;

        public MedicationsController(IMedicationService medicationService, IMapper mapper)
        {
            _medicationService = medicationService;
            _mapper = mapper;
        }

        /// <summary>
        /// List of medications
        /// </summary>
        /// <returns>List of medications.</returns>
        [HttpGet("")]
        public async Task<IActionResult> GetMedications()
        {
            var medications = await  _medicationService.GetAllMedications();

            var medicationResources = _mapper.Map < IEnumerable < Medication >, IEnumerable<MedicationResource>>(medications);

            return Ok(medicationResources);
        }

        /// <summary>
        /// Get a medication
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The medication.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedication(Guid id)
        {
            var medication = await _medicationService.GetMedicationById(id);

            if(medication == null)
            {
                return NotFound();
            }

            var medicationResource = _mapper.Map<Medication, MedicationResource>(medication);

            return Ok(medicationResource);
        }

        /// <summary>
        /// Create a medication
        /// </summary>
        /// <param name="medication"></param>
        /// <returns>The newly created medication.</returns>
        [HttpPost("")]
        public async Task<ActionResult<MedicationResource>> CreateMedication([FromBody] SaveMedicationResource saveMedicationResource)
        {
            var validator = new SaveMedicationResourceValidator();

            var validationResult = await validator.ValidateAsync(saveMedicationResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var medicationToCreate = _mapper.Map<SaveMedicationResource, Medication>(saveMedicationResource);

            var newMedication = await _medicationService.CreateMedication(medicationToCreate);

            var medication = await _medicationService.GetMedicationById(newMedication.MedicationId);

            var medicationResource =  _mapper.Map<Medication, MedicationResource>(medication);

            return Ok(medicationResource);

        }

        /// <summary>
        /// Edit medication
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The edited medication</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<MedicationResource>> EditMedication(Guid id, [FromBody] SaveMedicationResource saveMedicationResource)
        {
            var validator = new SaveMedicationResourceValidator();

            var validationResult = await validator.ValidateAsync(saveMedicationResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var medicationToBeUpdate = await _medicationService.GetMedicationById(id);
         
            if (medicationToBeUpdate == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var medication = _mapper.Map<SaveMedicationResource, Medication>(saveMedicationResource);

            await _medicationService.UpdateMedication(medicationToBeUpdate, medication);

            var updatedMedication = await _medicationService.GetMedicationById(id);

            var updatedMedicationResource = _mapper.Map<Medication, MedicationResource>(updatedMedication);

            return Ok(updatedMedicationResource);
        }

        /// <summary>
        /// Delete medication
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The deleted medication</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedication(Guid id)
        {
            var medication =await _medicationService.GetMedicationById(id);
             
            if(medication == null)
            {
                return NotFound();
            }

            await _medicationService.DeleteMedication(medication);

            return Ok("Medication deleted.");
        }
    }
}
