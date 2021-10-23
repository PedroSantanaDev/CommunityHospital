using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SaveNursingUnitResourceValidator : AbstractValidator<SaveNursingUnitResource>
    {
        public SaveNursingUnitResourceValidator()
        {
            RuleFor(nu => nu.Beds)
               .GreaterThan(0)
               .WithMessage("The number of beds must be greater than 0.");

            RuleFor(nu => nu.Specialty)
                .NotEmpty()
                .WithMessage("Specialty cannot be empty.");
        }
    }
}
