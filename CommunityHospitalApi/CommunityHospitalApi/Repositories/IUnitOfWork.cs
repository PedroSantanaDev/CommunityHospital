using System;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Departments { get; }
        IMedicationRepository Medications { get; }
        INursingUnitRepository NursingUnits { get; }
        IPhysicianRepository Physicians { get; }
        IProvinceRepository Provinces { get; }
        IPatientRepository Patients { get; }
        IVendorRepository Vendors { get; }
        IAdmissionRepository Admissions { get; }
        Task<int> CommitAsync();
    }
}
