using AutoMapper;
using CommunityHospitalApi.Models;
using CommunityHospitalApi.Resources;

namespace CommunityHospitalApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Department, DepartmentResource>();
            CreateMap<Medication, MedicationResource>();

            // Resource to Domain
            CreateMap<DepartmentResource, Department>();
            CreateMap<MedicationResource, Medication>();

            CreateMap<SaveDepartmentResource, Department>();
            CreateMap<SaveMedicationResource, Medication>();
        }
    }
}
