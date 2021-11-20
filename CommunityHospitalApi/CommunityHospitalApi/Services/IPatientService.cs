using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllPatients();
        Task<Patient> GetPatientById(Guid id);
        Task<Patient> CreatePatient(Patient newPatient);
        Task UpdatePatient(Patient patientToBeUpdated, Patient patient);
        Task DeletePatient(Patient patient);
    }
}
