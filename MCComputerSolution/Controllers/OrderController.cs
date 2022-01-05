using MCComputerSolution.Models.DTO;
using MCComputerSolution.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace MCComputerSolution.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public List<OrderDto>? GetAllOrders()
        {
            try
            {
                return _orderService.GetAllOrders();
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet("{orderNumber}")]
        public List<OrderDto>? SearchCustomers(string orderNumber)
        {
            try
            {
                return _orderService.SearchOrders(orderNumber);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPost]
        public object? CreateOrder(OrderDto orderDto)
        {
            try
            {
                return _orderService.CreateUpdateOrder(orderDto);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpPut]
        public object? UpdateOrder(OrderDto orderDto)
        {
            try
            {
                return _orderService.CreateUpdateOrder(orderDto);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpDelete("{orderId}")]
        public object? DeleteOrder(int orderId)
        {
            try
            {
                return _orderService.DeleteOrder(orderId);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
