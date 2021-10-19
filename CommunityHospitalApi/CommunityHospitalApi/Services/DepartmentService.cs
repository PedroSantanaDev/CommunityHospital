using CommunityHospitalApi.Models;
using CommunityHospitalApi.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Department> CreateDepartment(Department newDepartment)
        {
            await _unitOfWork.Departments.AddAsync(newDepartment);
            await _unitOfWork.CommitAsync();
            return newDepartment;
        }

        public async Task DeleteDepartment(Department department)
        {
            _unitOfWork.Departments.Remove(department);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await _unitOfWork.Departments.GetAllAsync();
        }

        public async Task<Department> GetDepartmentById(Guid id)
        {
            return await _unitOfWork.Departments.GetByIdAsync(id);
        }

        public async Task UpdateDepartment(Department departmentToBeUpdated, Department department)
        {
            departmentToBeUpdated.DepartmentName = department.DepartmentName;
            departmentToBeUpdated.ManagerFirstName = department.ManagerFirstName;
            departmentToBeUpdated.ManagerLastName = department.ManagerLastName;

            await _unitOfWork.CommitAsync();
        }
    }
}
