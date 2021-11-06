using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IPhysicianService
    {
        Task<IEnumerable<Physician>> GetAllPhysicians();
        Task<Physician> GetPhysicianById(Guid id);
        Task<Physician> CreatePhysician(Physician newPhysician);
        Task UpdatePhysician(Physician physicianToBeUpdated, Physician physician);
        Task DeletePhysician(Physician physician);
    }
}
