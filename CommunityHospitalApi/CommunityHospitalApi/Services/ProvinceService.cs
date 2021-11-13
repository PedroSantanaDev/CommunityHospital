using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class ProvinceService : IProvinceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProvinceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Province> CreateProvince(Province newProvince)
        {
            await _unitOfWork.Provinces.AddAsync(newProvince);
            await _unitOfWork.CommitAsync();
            return newProvince;
        }

        public async Task DeleteProvince(Province province)
        {
            _unitOfWork.Provinces.Remove(province);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Province>> GetAllProvinces()
        {
            return await _unitOfWork.Provinces.GetAllAsync();
        }

        public async Task<Province> GetProvinceById(Guid id)
        {
            return await _unitOfWork.Provinces.GetByIdAsync(id);
        }

        public async Task UpdateProvince(Province provinceToBeUpdated, Province province)
        {
            provinceToBeUpdated.ProvinceCode = province.ProvinceCode;
            provinceToBeUpdated.ProvinceName = province.ProvinceName;

            await _unitOfWork.CommitAsync();
        }
    }
}
