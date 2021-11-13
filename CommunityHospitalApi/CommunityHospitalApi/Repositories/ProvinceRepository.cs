using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        public ProvinceRepository(CommunityHospitalDbContext context) : base(context)
        {

        }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
