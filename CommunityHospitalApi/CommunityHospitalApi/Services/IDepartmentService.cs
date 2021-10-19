using CommunityHospitalApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<Department> GetDepartmentById(Guid id);
        Task<Department> CreateDepartment(Department newDepartment);
        Task UpdateDepartment(Department departmentToBeUpdated, Department department);
        Task DeleteDepartment(Department department);
    }
}
