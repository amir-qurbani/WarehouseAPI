using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Models;
using WarehouseAPI.Data;

namespace WarehouseAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework like Serilog, NLog, etc.)
                Console.WriteLine($"An error occurred while fetching products: {ex.Message}");
                // Return an empty list or handle it as per your application's needs
                throw new Exception("An error occurred while fetching products. Please try again later.");
            }

        }
        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return false;
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}