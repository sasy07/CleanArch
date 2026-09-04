using CleanArch.Application.Orders.DTOs;

namespace CleanArch.Application.Orders;

public interface IOrderService
{
    void AddOrder(AddOrderDto command);
    void FinallyOrder(FinallyOrderDto command);
    OrderDto GetOrder(long id);
    List<OrderDto> GetOrders();
}