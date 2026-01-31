using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Repositories
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task<List<Order>> GetAllAsync();
        Task<Order?> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}