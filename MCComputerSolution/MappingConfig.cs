using AutoMapper;
using MCComputerSolution.Models;
using MCComputerSolution.Models.DTO;

namespace MCComputerSolution
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}
