using CleanArch.Domain.Orders;
using CleanArch.Domain.Products;

namespace CleanArch.Infrastructure.Persistent.Memory;

public  class Context
{
    public  List<Product> Products { get; set; }

    public List<Order> Orders { get; set; } = [new Order(Guid.NewGuid(), 1, 10000)];
}