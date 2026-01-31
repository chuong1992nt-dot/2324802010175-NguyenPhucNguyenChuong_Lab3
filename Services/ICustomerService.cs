using ECommerce.Application.DTOs;

namespace ECommerce.Application.Services
{
    public interface ICustomerService
    {
        Task CreateCustomerAsync(CustomerDto customerDto);

        Task<CustomerDto?> GetCustomerByIdAsync(int id);
        Task<List<CustomerDto>> GetAllCustomersAsync();
        Task UpdateCustomerAsync(int id, CustomerDto customerDto);
        Task DeleteCustomerAsync(int id);
    }
}