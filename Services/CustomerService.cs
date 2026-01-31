using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Repositories;

namespace ECommerce.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateCustomerAsync(CustomerDto customerDto)
        {
            var customerEntity = new Customer
            {
                Name = customerDto.Name,
                Email = customerDto.Email,
                PhoneNumber = customerDto.PhoneNumber
            };

            await _repository.AddAsync(customerEntity);
        }

        public async Task<CustomerDto?> GetCustomerByIdAsync(int id)
        {
            var customerEntity = await _repository.GetByIdAsync(id);

            if (customerEntity == null) return null;

            return new CustomerDto
            {
                Id = customerEntity.Id,
                Name = customerEntity.Name,
                Email = customerEntity.Email,
                PhoneNumber = customerEntity.PhoneNumber
            };
        }
        public async Task<List<CustomerDto>> GetAllCustomersAsync()
        {
            var customers = await _repository.GetAllAsync();
            return customers.Select(c => new CustomerDto
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                PhoneNumber = c.PhoneNumber
            }).ToList();
        }

        public async Task UpdateCustomerAsync(int id, CustomerDto dto)
        {
            var existingCustomer = await _repository.GetByIdAsync(id);
            if (existingCustomer == null) throw new Exception("Customer not found");

            existingCustomer.Name = dto.Name;
            existingCustomer.Email = dto.Email;
            existingCustomer.PhoneNumber = dto.PhoneNumber;

            await _repository.UpdateAsync(existingCustomer);
        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}