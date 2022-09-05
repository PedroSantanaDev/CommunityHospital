using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IEncounterService
    {
        Task<IEnumerable<Encounter>> GetAllEncounters();
        Task<Encounter> GetEncounterById(Guid id);
        Task<Encounter> CreateEncounter(Encounter newEncounter);
        Task UpdateEncounter(Encounter encounterToBeUpdated, Encounter encounter);
        Task DeleteEncounter(Encounter encounter);
    }
}
