using CleanArch.Application.Orders;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers;

public class OrderController : BaseApiController
{
    private IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetOrders()
    {
        var orders = _orderService.GetOrders();
        return Ok(orders);
    }
}