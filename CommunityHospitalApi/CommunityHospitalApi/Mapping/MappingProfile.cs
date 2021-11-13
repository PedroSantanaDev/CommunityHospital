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
            CreateMap<NursingUnit, NursingUnitResource>();
            CreateMap<Physician, PhysicianResource>();
            CreateMap<Province, ProvinceResource>();

            //Resource to Domain
            CreateMap<DepartmentResource, Department>();
            CreateMap<MedicationResource, Medication>();
            CreateMap<NursingUnitResource, NursingUnit>();
            CreateMap<PhysicianResource, Physician>();
            CreateMap<ProvinceResource, Province>();

            CreateMap<SaveDepartmentResource, Department>();
            CreateMap<SaveMedicationResource, Medication>();
            CreateMap<SaveNursingUnitResource, NursingUnit>();
            CreateMap<SavePhysicianResource, Physician>();
            CreateMap<SaveProvinceResource, Province>();

        }
    }
}
