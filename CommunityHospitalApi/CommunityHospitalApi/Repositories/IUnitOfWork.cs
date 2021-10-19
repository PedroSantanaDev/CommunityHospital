using System;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Departments { get; }
        IMedicationRepository Medications { get; }
        Task<int> CommitAsync();
    }
}
