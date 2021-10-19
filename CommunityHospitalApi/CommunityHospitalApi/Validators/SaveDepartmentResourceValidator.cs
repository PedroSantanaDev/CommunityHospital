using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SaveDepartmentResourceValidator : AbstractValidator<SaveDepartmentResource>
    {
        public SaveDepartmentResourceValidator()
        {
            RuleFor(d => d.DepartmentName)
                .NotEmpty()
                .MaximumLength(50)
                .WithMessage("Department name must be provided.");
        }
    }
}
