using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class EncounterService : IEncounterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EncounterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Encounter> CreateEncounter(Encounter newEncounter)
        {
            await _unitOfWork.Encounters.AddAsync(newEncounter);
            await _unitOfWork.CommitAsync();
            return newEncounter;
        }

        public async Task DeleteEncounter(Encounter encounter)
        {
            _unitOfWork.Encounters.Remove(encounter);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Encounter>> GetAllEncounters()
        {
            return await _unitOfWork.Encounters.GetAllIncludingAsync(e => e.Patient, e => e.Physician);
        }

        public async Task<Encounter> GetEncounterById(Guid id)
        {
            return await _unitOfWork.Encounters.GetByIdAsync(id);
        }

        public async Task UpdateEncounter(Encounter encounterToBeUpdated, Encounter encounter)
        {
            encounterToBeUpdated.PatientId = encounter.PatientId;
            encounterToBeUpdated.PhysicianId = encounter.PhysicianId;
            encounterToBeUpdated.Notes = encounter.Notes;
            await _unitOfWork.CommitAsync();
        }
    }
}
