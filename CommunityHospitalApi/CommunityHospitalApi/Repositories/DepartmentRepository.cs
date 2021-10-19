using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(CommunityHospitalDbContext context)
            : base(context)
        { }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
