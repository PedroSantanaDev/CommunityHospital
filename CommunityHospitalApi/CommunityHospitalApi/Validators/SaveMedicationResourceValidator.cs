using CommunityHospitalApi.Resources;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityHospitalApi.Validators
{
    public class SaveMedicationResourceValidator : AbstractValidator<SaveMedicationResource>
    {
        public SaveMedicationResourceValidator()
        {
            RuleFor(m => m.MedicationDescription)
               .NotEmpty()
               .MaximumLength(50)
               .WithMessage("Medication description must be provided.");
        }
    }
}
