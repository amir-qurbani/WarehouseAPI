using System.Collections.Specialized;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using WarehouseAPI.Data;
using WarehouseAPI.Models;
using WarehouseAPI.Services;

namespace WarehouseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        // Nu ber vi om vår Service istället för databasen direkt
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                // Controllern frågar bara servicen: "Ge mig produkterna"
                var products = await _productService.GetAllProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                // Istället för att krascha, skickar vi 500 Internal Server Error
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            // Controllern säger: "Här är en produkt, spara den tack"
            var newProduct = await _productService.AddProductAsync(product);
            return CreatedAtAction(nameof(GetProducts), new { id = newProduct.Id }, newProduct);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteProduct(int id)
        {
            var success = await _productService.DeleteProductAsync(id);
            if (!success)
            {
                return NotFound();
            }
            return Ok(success);
        }
    }



}