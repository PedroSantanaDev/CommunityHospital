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
        private PhysicianRepository _physicianRepository;
        private ProvinceRepository _provinceRepository;
        private PatientRepository _patientRepository;
        private VendorRepository _vendorRepository;
        private AdmissionRepository _admissionRepository;
        private EncounterRepository _encounterRepository;

        public UnitOfWork(CommunityHospitalDbContext context)
        {
            _context = context;
        }

        public IDepartmentRepository Departments => _departmentRepository ??= new DepartmentRepository(_context);

        public IMedicationRepository Medications => _medicationRepository ??= new MedicationRepository(_context);

        public INursingUnitRepository NursingUnits => _nursingUnitRepository ??= new NursingUnitRepository(_context);

        public IPhysicianRepository Physicians => _physicianRepository ??= new PhysicianRepository(_context);

        public IProvinceRepository Provinces => _provinceRepository ??= new ProvinceRepository(_context);

        public IPatientRepository Patients => _patientRepository ??= new PatientRepository(_context);

        public IVendorRepository Vendors => _vendorRepository ??= new VendorRepository(_context);

        public IAdmissionRepository Admissions => _admissionRepository ??= new AdmissionRepository(_context);

        public IEncounterRepository Encounters => _encounterRepository ??= new EncounterRepository(_context);

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
