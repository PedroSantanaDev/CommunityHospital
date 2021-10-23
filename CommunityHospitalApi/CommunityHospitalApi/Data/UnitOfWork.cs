using CommunityHospitalApi.Database;
using CommunityHospitalApi.Repositories;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CommunityHospitalDbContext _context;
        private DepartmentRepository _departmentRepository;
        private MedicationRepository _medicationRepository;
        private NursingUnitRepository _nursingUnitRepository;

        public UnitOfWork(CommunityHospitalDbContext context)
        {
            _context = context;
        }

        public IDepartmentRepository Departments => _departmentRepository ??= new DepartmentRepository(_context);

        public IMedicationRepository Medications => _medicationRepository ??= new MedicationRepository(_context);

        public INursingUnitRepository NursingUnits => _nursingUnitRepository ??= new NursingUnitRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
