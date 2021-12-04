using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        public VendorRepository(CommunityHospitalDbContext context) : base(context)
        {

        }

        private CommunityHospitalDbContext DbContext => Context;

    }
}
