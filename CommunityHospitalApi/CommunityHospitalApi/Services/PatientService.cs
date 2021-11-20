using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Patient> CreatePatient(Patient newPatient)
        {
            await _unitOfWork.Patients.AddAsync(newPatient);
            await _unitOfWork.CommitAsync();
            return newPatient;
        }

        public async Task DeletePatient(Patient patient)
        {
            _unitOfWork.Patients.Remove(patient);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
           return await _unitOfWork.Patients.Include(p=>p.Province);
        }

        public async Task<Patient> GetPatientById(Guid id)
        {
            return await _unitOfWork.Patients.GetByIdAsync(id);
        }

        public async Task UpdatePatient(Patient patientToBeUpdated, Patient patient)
        {
            patientToBeUpdated.FirstName = patient.FirstName;
            patientToBeUpdated.LastName = patient.LastName;
            patientToBeUpdated.Gender = patient.Gender;
            patientToBeUpdated.BirthDate = patient.BirthDate;
            patientToBeUpdated.StreetAddress = patient.StreetAddress;
            patientToBeUpdated.City = patient.City;
            patientToBeUpdated.PostalCode = patient.PostalCode;
            patientToBeUpdated.HealthCard = patient.HealthCard;
            patientToBeUpdated.Allergies = patient.Allergies;
            patientToBeUpdated.PatientHeight = patient.PatientHeight;
            patientToBeUpdated.PatientWeight = patient.PatientWeight;
            patientToBeUpdated.ProvinceId = patient.ProvinceId;

            await _unitOfWork.CommitAsync();
        }
    }
}
