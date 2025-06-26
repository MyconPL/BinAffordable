using Application.Common.Interfaces;
using Application.Orders.Commands.CreateOrder;
using Domain.Entities;

namespace Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _context;

    public OrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(BinOrder order)
    {
        await _context.Orders.AddAsync(order);
    }

    public async Task<BinOrder?> GetByIdAsync(Guid id)
    {
       return await _context.Orders.FindAsync(id);
    }

    public async Task<IEnumerable<BinOrder>> GetAllAsync()
    {
        return await _context.Orders.ToListAsync();
    }
}