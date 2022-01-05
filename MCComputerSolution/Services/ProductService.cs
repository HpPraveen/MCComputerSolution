using AutoMapper;
using MCComputerSolution.DbContexts;
using MCComputerSolution.Models.DTO;
using MCComputerSolution.Services.IServices;

namespace MCComputerSolution.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericUnitOfWork _genericUnitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IGenericUnitOfWork genericUnitOfWork, IMapper mapper)
        {
            _genericUnitOfWork = genericUnitOfWork;
            _mapper = mapper;
        }

        public List<ProductDto>? GetAllProducts()
        {
            try
            {
                var productList = _genericUnitOfWork.ProductRepository.Get().ToList();
                if (productList == null) return null;
                return _mapper.Map<List<ProductDto>>(productList);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
