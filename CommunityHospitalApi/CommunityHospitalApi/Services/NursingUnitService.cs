using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class NursingUnitService : INursingUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        public NursingUnitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<NursingUnit> CreateNursingUnit(NursingUnit nursingUnit)
        {
            await _unitOfWork.NursingUnits.AddAsync(nursingUnit);
            await _unitOfWork.CommitAsync();
            return nursingUnit;

        }

        public async Task DeleteNursingUnit(NursingUnit nursingUnit)
        {
            _unitOfWork.NursingUnits.Remove(nursingUnit);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<NursingUnit>> GetAllNursingUnits()
        {
            return await _unitOfWork.NursingUnits.GetAllAsync();
        }

        public async Task<NursingUnit> GetNursingUnitById(string id)
        {
            return await _unitOfWork.NursingUnits.GetByIdAsync(id);
        }

        public async Task UpdateNursingUnit(NursingUnit nursingUnitToBeUpdated, NursingUnit nursingUnit)
        {
            nursingUnitToBeUpdated.Beds = nursingUnit.Beds;
            nursingUnitToBeUpdated.Extension = nursingUnit.Extension;
            nursingUnitToBeUpdated.ManagerFirstName = nursingUnit.ManagerFirstName;
            nursingUnitToBeUpdated.ManagerLastName = nursingUnit.ManagerLastName;
            nursingUnitToBeUpdated.Specialty = nursingUnit.Specialty;

            await _unitOfWork.CommitAsync();
        }
    }
}
