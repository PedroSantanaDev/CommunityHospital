using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IMedicationService
    {
        Task<IEnumerable<Medication>> GetAllMedications();
        Task<Medication> GetMedicationById(Guid id);
        Task<Medication> CreateMedication(Medication medication);
        Task UpdateMedication(Medication medicationToBeUpdated, Medication medication);
        Task DeleteMedication(Medication medication);
    }
}
