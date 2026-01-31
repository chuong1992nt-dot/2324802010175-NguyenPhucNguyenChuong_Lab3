using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetByIdAsync(int id);

        Task AddAsync(Customer customer);
        Task<List<Customer>> GetAllAsync();
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(int id);
    }
}