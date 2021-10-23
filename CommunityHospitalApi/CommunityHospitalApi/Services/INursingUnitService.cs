
using CommunityHospitalApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface INursingUnitService
    {
        Task<IEnumerable<NursingUnit>> GetAllNursingUnits();
        Task<NursingUnit> GetNursingUnitById(string id);
        Task<NursingUnit> CreateNursingUnit(NursingUnit nursingUnit);
        Task UpdateNursingUnit(NursingUnit nursingUnitToBeUpdated, NursingUnit nursingUnit);
        Task DeleteNursingUnit(NursingUnit nursingUnit);
    }
}
