﻿using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;

namespace CommunityHospitalApi.Repositories
{
    public class MedicationRepository : Repository<Medication>, IMedicationRepository
    {
        public MedicationRepository(CommunityHospitalDbContext context) : base(context)
        { }

        private CommunityHospitalDbContext DbContext => Context;
    }
}
