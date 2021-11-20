using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SavePatientResourceValidator : AbstractValidator<SavePatientResource>
    {
        public SavePatientResourceValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .WithMessage("Patient first name is required.");

            RuleFor(p => p.LastName)
                .NotEmpty()
                .WithMessage("Patient last name is required.");

            RuleFor(p => p.Gender)
                .NotEmpty()
                .WithMessage("Patient gender is required.");

            RuleFor(p => p.HealthCard)
                .NotEmpty()
                .WithMessage("Patient health card  number is required");
        }
    }
}
