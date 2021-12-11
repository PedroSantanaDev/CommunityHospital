using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IAdmissionService
    {
        Task<IEnumerable<Admission>> GetAllAdmissions();
        Task<Admission> GetAdmissionById(Guid id);
        Task<Admission> CreateAdmission(Admission newAdmission);
        Task UpdateAdmission(Admission admissionToBeUpdated, Admission admission);
        Task DeleteAdmission(Admission admission);
    }
}

