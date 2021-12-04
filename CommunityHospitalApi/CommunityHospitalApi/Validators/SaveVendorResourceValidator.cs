using CommunityHospitalApi.Resources;
using FluentValidation;

namespace CommunityHospitalApi.Validators
{
    public class SaveVendorResourceValidator : AbstractValidator<SaveVendorResource>
    {
        public SaveVendorResourceValidator()
        {
            RuleFor(v => v.VendorName)
               .NotEmpty()
               .WithMessage("Vendor first name is required.");
        }
    }
}
