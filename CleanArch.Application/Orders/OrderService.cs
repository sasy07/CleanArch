using CleanArch.Application.Orders.DTOs;
using CleanArch.Domain.Orders;
using CleanArch.Domain.Orders.Repository;

namespace CleanArch.Application.Orders;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    public void AddOrder(AddOrderDto command)
    {
        var order = new Order(command.ProductId, command.Count, command.Price);
        _orderRepository.Add(order);
        _orderRepository.SaveChanges();
    }

    public void FinallyOrder(FinallyOrderDto command)
    {
        var order = _orderRepository.GetById(command.OrderId);
        order.Finally();
        _orderRepository.Update(order);
        _orderRepository.SaveChanges();
    }

    public OrderDto GetOrder(long id)
    {
        var order = _orderRepository.GetById(id);
        return new OrderDto
        {
            Id = order.Id,
            ProductId = order.ProductId,
            Count = order.Count,
            Price = order.Price
        };
    }

    public List<OrderDto> GetOrders()
    {
        return _orderRepository.GetList()
            .Select(x => new OrderDto
            {
                Id = x.Id,
                ProductId = x.ProductId,
                Count = x.Count,
                Price = x.Price
            })
            .ToList();
    }
}