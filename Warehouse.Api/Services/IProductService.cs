using WarehouseAPI.Models;

namespace WarehouseAPI.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> AddProductAsync(Product product);
        Task<bool> DeleteProductAsync(int id);
    }
}