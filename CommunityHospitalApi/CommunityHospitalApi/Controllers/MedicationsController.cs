using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Controllers
{
    public class MedicationsController : Controller
    {
        private readonly CommunityHospitalDbContext _context;

        public MedicationsController(CommunityHospitalDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// List of medications
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        [HttpGet("Medications/{apiKey}")]
        public async Task<IActionResult> GetMedications(string apiKey)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

            return Ok(await _context.Medications.ToListAsync());
        }

        /// <summary>
        /// Get a medication
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Medication/{apiKey}/{id}")]
        public async Task<IActionResult> GetMedication(string apiKey, Guid? id)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medications
                .FirstOrDefaultAsync(m => m.MedicationId == id);

            if (medication == null)
            {
                return NotFound();
            }

            return Ok(medication);
        }

        /// <summary>
        /// Create a medication
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="medication"></param>
        /// <returns></returns>
        [HttpPost("CreateMedication/{apiKey}")]
        public async Task<IActionResult> CreateMedication(string apiKey, [Bind("MedicationId, MedicationDescription, MedicationCost, PackageSize, Strength, Sig, UnitsUsedYtd, LastPrescribedDate")] Medication medication)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            medication.MedicationId = Guid.NewGuid();
            _context.Add(medication);
            
            await _context.SaveChangesAsync();
               
            return Ok(medication);
        }

        /// <summary>
        /// Edit medication
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <param name="medication"></param>
        /// <returns></returns>
        [HttpPut("EditMedication/{apiKey}/{id}")]
        public async Task<IActionResult> EditMedication(string apiKey, Guid id, [Bind("MedicationId,MedicationDescription,MedicationCost,PackageSize,Strength,Sig,UnitsUsedYtd,LastPrescribedDate")] Medication medication)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

            if (id != medication.MedicationId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!_context.Medications.Any(d => d.MedicationId == id))
            {
                return NotFound();
            }

            _context.Update(medication);
           await _context.SaveChangesAsync();

           return Ok(medication);           
        }

        /// <summary>
        /// Delete medication
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("DeleteMedication/{apiKey}/{id}")]
        public async Task<IActionResult> DeleteMedication(string apiKey, Guid? id)
        {
            if (!Shared.Helper.IsApiKeyValid(apiKey))
            {
                return Unauthorized("Invalid Api key.");
            }

            if (id == null)
            {
                return NotFound();
            }

            var medication = await _context.Medications.FindAsync(id);
           
            if (medication == null)
            {
                return NotFound();
            }

            _context.Medications.Remove(medication);
            await _context.SaveChangesAsync();

            return Ok(medication);
        }
    }
}
