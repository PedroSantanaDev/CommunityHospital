using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class PhysicianRepository : Repository<Physician>, IPhysicianRepository
    {
        public PhysicianRepository(CommunityHospitalDbContext context) : base (context)
        {
        }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
