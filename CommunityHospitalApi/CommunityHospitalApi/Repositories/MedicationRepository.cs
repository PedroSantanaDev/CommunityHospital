using CommunityHospitalApi.Database;
using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Repositories
{
    public class MedicationRepository : Repository<Medication>, IMedicationRepository
    {
        public MedicationRepository(CommunityHospitalDbContext context)
            : base(context)
        { }


        private CommunityHospitalDbContext DbContext => Context;
    }
}
