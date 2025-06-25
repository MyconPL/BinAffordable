using Domain.Entities;

namespace Application.Common.Interfaces;

public interface IOrderRepository
{
    Task AddAsync(BinOrder order);
    Task<BinOrder?> GetByIdAsync(Guid id);
    Task<IEnumerable<BinOrder>> GetAllAsync();
}