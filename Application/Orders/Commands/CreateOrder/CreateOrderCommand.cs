using System.ComponentModel;
using Domain.Enums;

namespace Application.Orders.Commands.CreateOrder;

public record CreateOrderCommand(
    string CustomerFirstName,
    string CustomerLastName,
    string PhoneNumber,
    string Address,
    DateTime DeliveryDate,
    DateTime PickupDate,
    ContainerSize ContainerSize,
    WasteCategory WasteCategory,
    string? Notes
    ) : IRequest<Guid>;