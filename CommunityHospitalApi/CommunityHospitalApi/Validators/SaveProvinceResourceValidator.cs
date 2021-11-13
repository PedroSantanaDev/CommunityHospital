using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SaveProvinceResourceValidator : AbstractValidator<SaveProvinceResource>
    {
        public SaveProvinceResourceValidator()
        {
            RuleFor(p => p.ProvinceCode)
                .NotEmpty()
                .MinimumLength(2)
                .WithMessage("Province code must be a minimum of two characters.");

            RuleFor(p => p.ProvinceName)
                .NotEmpty()
                .WithMessage("Province name cannot be empty.");               
        }
    }
}
