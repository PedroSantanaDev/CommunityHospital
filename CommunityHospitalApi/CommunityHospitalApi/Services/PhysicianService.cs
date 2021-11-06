using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class PhysicianService : IPhysicianService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PhysicianService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Physician> CreatePhysician(Physician newPhysician)
        {
            await _unitOfWork.Physicians.AddAsync(newPhysician);
            await _unitOfWork.CommitAsync();
            return newPhysician;
        }

        public async Task DeletePhysician(Physician physician)
        {
             _unitOfWork.Physicians.Remove(physician);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Physician>> GetAllPhysicians()
        {
            return await _unitOfWork.Physicians.GetAllAsync();
        }

        public async Task<Physician> GetPhysicianById(Guid id)
        {
            return await _unitOfWork.Physicians.GetByIdAsync(id);
        }

        public async Task UpdatePhysician(Physician physicianToBeUpdated, Physician physician)
        {
            physicianToBeUpdated.FirstName = physician.FirstName;
            physicianToBeUpdated.LastName = physician.LastName;
            physicianToBeUpdated.Specialty = physician.Specialty;
            physicianToBeUpdated.Phone = physician.Phone;
            physicianToBeUpdated.OHIPRegistration = physician.OHIPRegistration;

            await _unitOfWork.CommitAsync();
        }
    }
}
