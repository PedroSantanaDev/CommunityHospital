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
    public class VendorsController : Controller
    {
        private readonly IVendorService _vendorService;
        private readonly IMapper _mapper;
        public VendorsController(IVendorService vendorService, IMapper mapper)
        {
            _vendorService = vendorService;
            _mapper = mapper;
        }
        /// <summary>
        /// Get all vendors
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> GetVendors()
        {
            var vendors = await _vendorService.GetAllVendors();

            var vendorResources = _mapper.Map<IEnumerable<Vendor>, IEnumerable<VendorResource>>(vendors);

            return Ok(vendorResources);
        }
        /// <summary>
        /// Get a vender
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVendor(Guid id)
        {
            var vendor = await _vendorService.GetVendorById(id);

            if(vendor == null)
            {
                return NotFound();
            }

            var vendorResource = _mapper.Map<Vendor, VendorResource>(vendor);

            return Ok(vendorResource);
        }
        /// <summary>
        /// Create vendor
        /// </summary>
        /// <param name="saveVendorResource"></param>
        /// <returns></returns>
        [HttpPost("")]
        public async Task<ActionResult<VendorResource>> CreateVendor([FromBody] SaveVendorResource saveVendorResource)
        {
            var validator = new SaveVendorResourceValidator();

            var validationResult = await validator.ValidateAsync(saveVendorResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var vendorToCreate = _mapper.Map<SaveVendorResource, Vendor>(saveVendorResource);

            var newVendor = await _vendorService.CreateVendor(vendorToCreate);

            var vendor = await _vendorService.GetVendorById(newVendor.VendorId);

            var vendorResource = _mapper.Map<Vendor, VendorResource>(vendor);

            return Ok(vendorResource);
        }
        /// <summary>
        /// Edit vendor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saveVendorResource"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<VendorResource>> EditVendor(Guid id, [FromBody] SaveVendorResource saveVendorResource)
        {
            var validator = new SaveVendorResourceValidator();

            var validationResult = await validator.ValidateAsync(saveVendorResource);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            var vendorToBeUpdated = await _vendorService.GetVendorById(id);

            if (vendorToBeUpdated == null)
            {
                return NotFound();
            }

            var vendor = _mapper.Map<SaveVendorResource, Vendor>(saveVendorResource);

            await _vendorService.UpdateVendor(vendorToBeUpdated, vendor);

            var updatedVendor = await _vendorService.GetVendorById(id);

            var updatedVendorResource = _mapper.Map<Vendor, VendorResource>(updatedVendor);

            return Ok(updatedVendorResource);
        }
        /// <summary>
        /// Delete vendor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendor(Guid id)
        {
            var vendor = await _vendorService.GetVendorById(id);

            if (vendor == null)
            {
                return NotFound();
            }

            await _vendorService.DeleteVendor(vendor);

            return Ok("Vendor deleted.");
        }
    }
}
