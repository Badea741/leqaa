using BusinessLogic.Application.Commands.Hubs.DeployHub;
using FluentValidation;

namespace BusinessLogic.Application.Validations.HubValidations;
public class DeployHubValidator : AbstractValidator<DeployHubCommand>
{
    public DeployHubValidator()
    {
        RuleFor(h => h.Name)
        .NotEmpty()
        .MaximumLength(100)
        .WithMessage("Hub name is neither empty or too long, Please specify only 100 characters or less");

        RuleFor(h => h.Description)
        .MaximumLength(4000)
        .WithMessage("Hub description is too long, Please specify only 4000 characters or less");

    }
}