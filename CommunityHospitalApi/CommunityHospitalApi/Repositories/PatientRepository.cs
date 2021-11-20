using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(CommunityHospitalDbContext context) : base(context)
        {
        }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
