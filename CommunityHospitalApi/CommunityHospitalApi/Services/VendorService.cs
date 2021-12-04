using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class VendorService : IVendorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VendorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Vendor> CreateVendor(Vendor newVendor)
        {
            await _unitOfWork.Vendors.AddAsync(newVendor);
            await _unitOfWork.CommitAsync();
            return newVendor;
        }

        public async Task DeleteVendor(Vendor Vendor)
        {
            _unitOfWork.Vendors.Remove(Vendor);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Vendor>> GetAllVendors()
        {
            return await _unitOfWork.Vendors.GetAllIncludingAsync(includeProperties: v => v.Province);
        }

        public async Task<Vendor> GetVendorById(Guid id)
        {
            return await _unitOfWork.Vendors.GetByIdAsync(id);
        }

        public async Task UpdateVendor(Vendor VendorToBeUpdated, Vendor Vendor)
        {
            VendorToBeUpdated.VendorName = Vendor.VendorName;
            VendorToBeUpdated.ContactFirstName = Vendor.ContactFirstName;
            VendorToBeUpdated.ContactLastName = Vendor.ContactLastName;
            VendorToBeUpdated.City = Vendor.City;
            VendorToBeUpdated.StreetAddress = Vendor.StreetAddress;
            VendorToBeUpdated.PostalCode = Vendor.PostalCode;
            VendorToBeUpdated.PurchasesYtd = Vendor.PurchasesYtd;
            VendorToBeUpdated.ProvinceId = Vendor.ProvinceId;

           await _unitOfWork.CommitAsync();
        }
    }
}
