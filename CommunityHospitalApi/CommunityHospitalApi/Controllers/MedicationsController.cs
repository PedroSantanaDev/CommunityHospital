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
        /// <remarks>
        /// Sample request:
        /// Get Medications/{apiKey}
        /// {
        /// }
        /// </remarks>
        /// <returns>List of medications.</returns>
        [HttpGet]
        public async Task<IActionResult> GetMedications()
        {
            return Ok(await _context.Medications.ToListAsync());
        }

        /// <summary>
        /// Get a medication
        /// </summary>
        ///  /// <remarks>
        /// Sample request:
        /// Get Medications/{apiKey}/{id}
        /// {
        /// }
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>The medication.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMedication(Guid id)
        {          
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
        /// /// <remarks>
        /// Sample request:
        /// Post Medications/{apiKey}
        /// {
        ///     "MedicationId" = "1D27F736-2BA7-484A-A939-D63344E81194",
        ///     "MedicationDescription" = "Ventolin Inhaler",
        ///     "MedicationCost" = 12.45,
        ///     "PackageSize" = "Case Of 12",
        ///     "Strength" = "1 MG/MIN",
        ///     "Sig" = "STAT",
        ///     "UnitsUsedYtd" = 4,
        ///     "LastPrescribedDate = "2015-05-30 00:00:00.0000000"
        /// }
        /// </remarks>
        /// <param name="medication"></param>
        /// <returns>The newly created medication.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateMedication( [Bind("MedicationId, MedicationDescription, MedicationCost, PackageSize, Strength, Sig, UnitsUsedYtd, LastPrescribedDate")] Medication medication)
        {
        
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
        /// Sample request:
        /// Put EditMedication/{apiKey}/{id}
        /// {
        ///     "MedicationId" = "1D27F736-2BA7-484A-A939-D63344E81194",
        ///     "MedicationDescription" = "Ventolin Inhaler",
        ///     "MedicationCost" = 12.45,
        ///     "PackageSize" = "Case Of 12",
        ///     "Strength" = "1 MG/MIN",
        ///     "Sig" = "STAT",
        ///     "UnitsUsedYtd" = 4,
        ///     "LastPrescribedDate = "2015-05-30 00:00:00.0000000"
        /// }
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="medication"></param>
        /// <returns>The edited medication</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> EditMedication(Guid id, [Bind("MedicationId,MedicationDescription,MedicationCost,PackageSize,Strength,Sig,UnitsUsedYtd,LastPrescribedDate")] Medication medication)
        {
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
        /// ///  /// <remarks>
        /// Sample request:
        /// Delete DeleteMedication/{apiKey}/{id}
        /// {
        /// }
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>The deleted medication</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedication(Guid? id)
        {
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
