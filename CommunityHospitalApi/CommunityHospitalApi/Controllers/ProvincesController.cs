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
    public class ProvincesController : Controller
    {
        private IProvinceService _provinceService;
        private readonly IMapper _mapper;

        public ProvincesController(IProvinceService provinceService, IMapper mapper)
        {
            _provinceService = provinceService;
            _mapper = mapper;
        }
        /// <summary>
        /// Get all provinces
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetProvinces()
        {
            var provinces = await _provinceService.GetAllProvinces();

            var provinceResources = _mapper.Map<IEnumerable<Province>, IEnumerable<ProvinceResource>>(provinces);

            return Ok(provinceResources);
        }
        /// <summary>
        /// Get a province
        /// </summary>
        /// <param name="id">Province id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProvince(Guid id)
        {
            var province = await _provinceService.GetProvinceById(id);

            if(province == null)
            {
                return NotFound();
            }

            var provinceResource = _mapper.Map<Province, ProvinceResource>(province);

            return Ok(provinceResource);
        }
        /// <summary>
        /// Create province
        /// </summary>
        /// <param name="saveProvinceResource">Province resource</param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<ProvinceResource>> CreateProvince([FromBody] SaveProvinceResource saveProvinceResource)
        {
            var validator = new SaveProvinceResourceValidator();

            var validationResult = await validator.ValidateAsync(saveProvinceResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var provinceToCreate = _mapper.Map<SaveProvinceResource, Province>(saveProvinceResource);

            var newProvince = await _provinceService.CreateProvince(provinceToCreate);

            var province = await _provinceService.GetProvinceById(newProvince.ProvinceId);

            var provinceResource = _mapper.Map<Province, ProvinceResource>(province);

            return Ok(provinceResource);
        }
        /// <summary>
        /// Edit a province
        /// </summary>
        /// <param name="id">Province id </param>
        /// <param name="saveProvinceResource">Province resource</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<ProvinceResource>> EditProvince(Guid id, [FromBody] SaveProvinceResource saveProvinceResource)
        {
            var validator = new SaveProvinceResourceValidator();

            var validationResult = await validator.ValidateAsync(saveProvinceResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var provinceToBeUpdated = await _provinceService.GetProvinceById(id);

            if (provinceToBeUpdated == null)
            {
                NotFound();
            }

            var province = _mapper.Map<SaveProvinceResource, Province>(saveProvinceResource);

            await _provinceService.UpdateProvince(provinceToBeUpdated, province);

            var updatedProvince = await _provinceService.GetProvinceById(id);

            var updatedProvinceResource = _mapper.Map<Province, ProvinceResource>(updatedProvince);

            return Ok(updatedProvinceResource);
        }
        /// <summary>
        /// Delete a province
        /// </summary>
        /// <param name="id">Province id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvince(Guid id)
        {
            var province = await _provinceService.GetProvinceById(id);

            if (province == null)
            {
                NotFound();
            }

            await _provinceService.DeleteProvince(province);

            return Ok("Province deleted.");
        }
    }
}
