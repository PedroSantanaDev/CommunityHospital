using AutoMapper;
using CommunityHospitalApi.Attributes;
using CommunityHospitalApi.Models;
using CommunityHospitalApi.Resources;
using CommunityHospitalApi.Services;
using CommunityHospitalApi.Validators;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CommunityHospitalApi.Controllers
{
    [ApiKey]
    [ApiController]
    [Route("[controller]")]
    public class NursingUnitsController : Controller
    {
        private readonly INursingUnitService _nursingUnitService;
        private readonly IMapper _mapper;

        public NursingUnitsController(INursingUnitService nursingUnitService, IMapper mapper)
        {
            _nursingUnitService = nursingUnitService;
            _mapper = mapper;
        }

        /// <summary>
        /// List of nursing units
        /// </summary>
        /// <returns>List of nursing units</returns>
        [HttpGet("")]
        public async Task<IActionResult> GetNursingUnits()
        {
            var nursingUnits = await _nursingUnitService.GetAllNursingUnits();

            var nursingUnitsResources = _mapper.Map<IEnumerable<NursingUnit>, IEnumerable<NursingUnitResource>>(nursingUnits);

            return Ok(nursingUnitsResources);
        }

        /// <summary>
        /// Get a nursing unit
        /// </summary>
        /// <param name="id"></param>
        /// <returns>nursing unit</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNursingUnit(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Provide a valid Nursing Unit id");
            }

            var nursingUnit = await _nursingUnitService.GetNursingUnitById(id);

            if (nursingUnit == null)
            {
                return NotFound();
            }

            var nursingUnitResource = _mapper.Map<NursingUnit, NursingUnitResource>(nursingUnit);

            return Ok(nursingUnitResource);
        }

        /// <summary>
        /// Create nursing unit
        /// </summary>
        /// <param name="saveNursingUnitResource"></param>
        /// <returns>Newly created nursing unit</returns>
        [HttpPost("")]
        public async Task<ActionResult<NursingUnitResource>> CreateNursingUnit([FromBody] SaveNursingUnitResource saveNursingUnitResource)
        {
            var validator = new SaveNursingUnitResourceValidator();

            var validationResult = await validator.ValidateAsync(saveNursingUnitResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var nursingUnitToCreate = _mapper.Map<SaveNursingUnitResource, NursingUnit>(saveNursingUnitResource);

            var newNursingUnit = await _nursingUnitService.CreateNursingUnit(nursingUnitToCreate);

            var nursingUnit = await _nursingUnitService.GetNursingUnitById(newNursingUnit.NursingUnitId);

            var nursingUnitResource = _mapper.Map<NursingUnit, NursingUnitResource>(nursingUnit);

            return Ok(nursingUnitResource);
        }

        /// <summary>
        /// Edit nursing unit
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saveNursingUnitResource"></param>
        /// <returns>Newly updated nursing unit</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<NursingUnitResource>> EditNursingUnit(string id, [FromBody] SaveNursingUnitResource saveNursingUnitResource)
        {
            var validator = new SaveNursingUnitResourceValidator();

            var validationResult = await validator.ValidateAsync(saveNursingUnitResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var nursingUnitToUpdate = await _nursingUnitService.GetNursingUnitById(id);

            if (nursingUnitToUpdate == null)
            {
                return NotFound();
            }

            var nursingUnit = _mapper.Map<SaveNursingUnitResource, NursingUnit>(saveNursingUnitResource);

            await _nursingUnitService.UpdateNursingUnit(nursingUnitToUpdate, nursingUnit);

            var updatedNursingUnit = await _nursingUnitService.GetNursingUnitById(id);

            var updatedNursingUnitResource = _mapper.Map<NursingUnit, NursingUnitResource>(updatedNursingUnit);

            return Ok(updatedNursingUnitResource);

        }

        /// <summary>
        /// Delete a nursing unit
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNursingUnit(string id)
        {
            var nursingUnit = await _nursingUnitService.GetNursingUnitById(id);

            if(nursingUnit == null)
            {
                return NotFound();
            }

            await _nursingUnitService.DeleteNursingUnit(nursingUnit);

            return Ok("Nursing unit deleted.");
        }
    }
}
