using FluentValidation;

namespace Application.Orders.Commands.CreateOrder;

public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderValidator()
    {
        RuleFor(x => x.CustomerFirstName).NotEmpty().MaximumLength(50);
        RuleFor(x => x.CustomerLastName).NotEmpty().MaximumLength(50);
        RuleFor(x => x.PhoneNumber).NotEmpty().Matches(@"^\+?\d{7,15}$");
        RuleFor(x => x.Address).NotEmpty().MaximumLength(100);
        RuleFor(x => x.DeliveryDate).GreaterThan(DateTime.Today.AddDays(-1));
        RuleFor(x => x.PickupDate).GreaterThanOrEqualTo(x => x.DeliveryDate).When(x => x.PickupDate.HasValue);
        RuleFor(x => x.ContainerSize).IsInEnum();
        RuleFor(x => x.WasteCategory).IsInEnum();
    }
}
