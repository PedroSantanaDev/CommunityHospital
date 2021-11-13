using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IProvinceService
    {
        Task<IEnumerable<Province>> GetAllProvinces();
        Task<Province> GetProvinceById(Guid id);
        Task<Province> CreateProvince(Province newProvince);
        Task UpdateProvince(Province provinceToBeUpdated, Province province);
        Task DeleteProvince(Province province);
    }
}
