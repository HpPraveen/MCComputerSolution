using MCComputerSolution.Models.DTO;

namespace MCComputerSolution.Services.IServices
{
    public interface IProductService
    {
        List<ProductDto>? GetAllProducts();
    }
}
