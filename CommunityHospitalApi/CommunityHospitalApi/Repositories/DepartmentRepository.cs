﻿using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

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
