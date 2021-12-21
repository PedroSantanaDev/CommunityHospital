using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class AdmissionService : IAdmissionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdmissionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Admission> CreateAdmission(Admission newAdmission)
        {
            await _unitOfWork.Admissions.AddAsync(newAdmission);
            await _unitOfWork.CommitAsync();
            return newAdmission;
        }

        public async Task DeleteAdmission(Admission admission)
        {
             _unitOfWork.Admissions.Remove(admission);
             await _unitOfWork.CommitAsync();
        }

        public async Task<Admission> GetAdmissionById(Guid id)
        {
            return await _unitOfWork.Admissions.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Admission>> GetAllAdmissions()
        {
            return await _unitOfWork.Admissions.GetAllIncludingAsync(a => a.Physician, a => a.NursingUnit, a => a.Patient);
        }

        public async Task UpdateAdmission(Admission admissionToBeUpdated, Admission admission)
        {
            admissionToBeUpdated.NursingUnitId = admission.NursingUnitId;
            admissionToBeUpdated.PatientId = admission.PatientId;
            admissionToBeUpdated.PhysicianId = admission.PhysicianId;
            admissionToBeUpdated.PrimaryDiagnosis = admission.PrimaryDiagnosis;
            admissionToBeUpdated.SecondaryDiagnoses = admission.SecondaryDiagnoses;
            admissionToBeUpdated.RoomNumber = admission.RoomNumber;
            admissionToBeUpdated.AdmissionDate = admission.AdmissionDate;
            admissionToBeUpdated.DischargeDate = admission.DischargeDate;
            admissionToBeUpdated.BedNumber = admission.BedNumber;
            
            await _unitOfWork.CommitAsync();
        }
    }
}
