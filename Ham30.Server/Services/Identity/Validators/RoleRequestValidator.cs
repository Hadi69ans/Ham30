
using FluentValidation;
using Ham30.Server.Services.Identity.Requests;
using Microsoft.Extensions.Localization;

namespace Ham30.Server.Services.Identity.Validators
{
    public class RoleRequestValidator : AbstractValidator<RoleRequest>
    {
        public RoleRequestValidator(IStringLocalizer<RoleRequestValidator> localizer)
        {
            RuleFor(request => request.Name)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => localizer["Name is required"]);
        }
    }
}
