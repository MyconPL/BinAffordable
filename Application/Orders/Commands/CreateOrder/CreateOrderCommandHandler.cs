using Application.Common.Interfaces;
using Domain.Entities;
using Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Orders.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
{
    public CreateOrderCommandHandler(IOrderRepository orderRepository)
    {
        _repository = repository;
    }
    
    public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new BinOrder(
            request.CustomerFirstName,
            request.CustomerLastName,
            request.PhoneNumber,
            request.Address,
            request.DeliveryDate,
            request.PickupDate,
            request.ContainerSize,
            request.WasteCategory,
            request.Notes
        );
        
        await _repository.AddAsync(order);
        return order.Id;

    }
}