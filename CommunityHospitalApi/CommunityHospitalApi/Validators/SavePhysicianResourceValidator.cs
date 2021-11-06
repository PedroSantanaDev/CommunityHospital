using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SavePhysicianResourceValidator : AbstractValidator<SavePhysicianResource>
    {
        public SavePhysicianResourceValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                .WithMessage("Physician first name is required.");

            RuleFor(p => p.LastName)
                .NotEmpty()
                .WithMessage("Physician last name is required.");
            
        }
    }
}
