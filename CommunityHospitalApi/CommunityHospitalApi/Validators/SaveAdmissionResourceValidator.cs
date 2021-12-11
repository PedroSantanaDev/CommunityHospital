using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SaveAdmissionResourceValidator : AbstractValidator<SaveAdmissionResource>
    {
        public SaveAdmissionResourceValidator()
        {
            RuleFor(a => a.AdmissionDate)
               .NotEmpty()
               .WithMessage("Admission date is required.");
            RuleFor(a => a.PatientId)
               .NotEmpty()
               .WithMessage("Patient id is required.");
        }
    }
}
