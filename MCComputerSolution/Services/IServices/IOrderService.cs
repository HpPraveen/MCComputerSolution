using MCComputerSolution.Models.DTO;

namespace MCComputerSolution.Services.IServices
{
    public interface IOrderService
    {
        List<OrderDto>? GetAllOrders();
        List<OrderDto>? SearchOrders(string orderNumber);
        OrderDto CreateUpdateOrder(OrderDto orderDto);
        bool DeleteOrder(int orderId);
    }
}
