using MCComputerSolution.Models.DTO;
using MCComputerSolution.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MCComputerSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<ProductDto>? GetAllProducts()
        {
            try
            {
                return _productService.GetAllProducts();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
