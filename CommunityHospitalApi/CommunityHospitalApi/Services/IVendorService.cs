using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IVendorService
    {
        Task<IEnumerable<Vendor>> GetAllVendors();
        Task<Vendor> GetVendorById(Guid id);
        Task<Vendor> CreateVendor(Vendor newVendor);
        Task UpdateVendor(Vendor VendorToBeUpdated, Vendor Vendor);
        Task DeleteVendor(Vendor Vendor);
    }
}
