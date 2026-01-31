using ECommerce.Application.DTOs;

namespace ECommerce.Application.Services
{
    public interface IProductService
    {
        Task CreateProductAsync(ProductDto productDto);
        Task<List<ProductDto>> GetAllProductsAsync();
        Task<ProductDto?> GetProductByIdAsync(int id);
    }
}