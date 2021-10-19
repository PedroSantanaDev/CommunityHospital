using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class MedicationService : IMedicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MedicationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Medication> CreateMedication(Medication newMedication)
        {
            await _unitOfWork.Medications.AddAsync(newMedication);
            await _unitOfWork.CommitAsync();
            return newMedication;
        }

        public async Task DeleteMedication(Medication medication)
        {
            _unitOfWork.Medications.Remove(medication);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Medication>> GetAllMedications()
        {
            return await _unitOfWork.Medications.GetAllAsync();
        }

        public async Task<Medication> GetMedicationById(Guid id)
        {
            return await _unitOfWork.Medications.GetByIdAsync(id);
        }

        public async Task UpdateMedication(Medication medicationToBeUpdated, Medication medication)
        {
            medicationToBeUpdated.LastPrescribedDate = medication.LastPrescribedDate;
            medicationToBeUpdated.MedicationCost = medication.MedicationCost;
            medicationToBeUpdated.MedicationDescription = medication.MedicationDescription;
            medicationToBeUpdated.PackageSize = medication.PackageSize;
            medicationToBeUpdated.Sig = medication.Sig;
            medicationToBeUpdated.Strength = medication.Strength;
            medicationToBeUpdated.LastPrescribedDate = medication.LastPrescribedDate;
            medicationToBeUpdated.UnitsUsedYtd = medication.UnitsUsedYtd;

            await _unitOfWork.CommitAsync();
        }
    }
}
