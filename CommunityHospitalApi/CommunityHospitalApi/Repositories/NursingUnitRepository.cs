using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class NursingUnitRepository : Repository<NursingUnit>, INursingUnitRepository
    {
        public NursingUnitRepository(CommunityHospitalDbContext context) : base(context)
        {}

        private CommunityHospitalDbContext DbContext => Context;
    }
}
