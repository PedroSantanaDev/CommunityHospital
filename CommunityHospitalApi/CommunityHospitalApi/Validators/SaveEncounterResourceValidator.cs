using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SaveEncounterResourceValidator : AbstractValidator<SaveEncounterResource>
    {
        public SaveEncounterResourceValidator()
        {
            RuleFor(e => e.PhysicianId)
                .NotEmpty()
                .WithMessage("Admission date is required.");

            RuleFor(e => e.PhysicianId)
                .NotEmpty()
                .WithMessage("Physician id is required");

            RuleFor(e => e.Notes)
                .NotEmpty()
                .WithMessage("Notes cannot be empty.");
            RuleFor(e => e.EncounterDateTime)
                .NotEmpty()
                .WithMessage("Encounter date and time is required.");
        }
    }
}
