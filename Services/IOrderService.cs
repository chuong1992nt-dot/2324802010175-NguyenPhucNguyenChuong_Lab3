using ECommerce.Application.DTOs;

namespace ECommerce.Application.Services
{
    public interface IOrderService
    {
        Task PlaceOrderAsync(CreateOrderDto orderDto);
        Task<List<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto?> GetOrderByIdAsync(int id);
        Task DeleteOrderAsync(int id);
    }
}