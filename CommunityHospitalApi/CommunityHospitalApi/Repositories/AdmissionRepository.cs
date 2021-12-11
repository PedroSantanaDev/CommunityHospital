using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class AdmissionRepository : Repository<Admission>, IAdmissionRepository
    {
        public AdmissionRepository(CommunityHospitalDbContext context) : base(context)
        {

        }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
