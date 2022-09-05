using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class EncounterRepository : Repository<Encounter>, IEncounterRepository
    {
        public EncounterRepository(CommunityHospitalDbContext context) : base(context)
        {

        }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
