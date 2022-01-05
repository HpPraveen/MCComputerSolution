using AutoMapper;
using MCComputerSolution.DbContexts;
using MCComputerSolution.Models;
using MCComputerSolution.Models.DTO;
using MCComputerSolution.Services.IServices;

namespace MCComputerSolution.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericUnitOfWork _genericUnitOfWork;
        private readonly IMapper _mapper;

        public OrderService(IGenericUnitOfWork genericUnitOfWork, IMapper mapper)
        {
            _genericUnitOfWork = genericUnitOfWork;
            _mapper = mapper;
        }

        public List<OrderDto>? GetAllOrders()
        {
            try
            {
                var orderList = _genericUnitOfWork.OrderRepository.Get().ToList();
                if (orderList == null) return null;
                return _mapper.Map<List<OrderDto>>(orderList);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<OrderDto>? SearchOrders(string orderNumber)
        {
            try
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                var orderList = _genericUnitOfWork.OrderRepository.Get(o => o.OrderNumber.Contains(orderNumber)).ToList();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                if (orderList == null) return null;
                return _mapper.Map<List<OrderDto>>(orderList);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public OrderDto CreateUpdateOrder(OrderDto orderDto)
        {
            try
            {
                var order = _mapper.Map<Order>(orderDto);
                if (order.OId > 0)
                {
                    order.SysUpdatedOn = DateTime.Now;
                    _genericUnitOfWork.OrderRepository.Update(order);
                }
                else
                {
                    order.SysCreatedOn = DateTime.Now;
                    _genericUnitOfWork.OrderRepository.Insert(order);
                }
                _genericUnitOfWork.SaveChanges();
                order.OrderNumber = order.OId.ToString();
                return _mapper.Map<OrderDto>(order);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                var order = _genericUnitOfWork.OrderRepository.Get(o => o.OId == orderId).FirstOrDefault();
                if (order == null) return false;
                _genericUnitOfWork.OrderRepository.Delete(order);
                _genericUnitOfWork.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
