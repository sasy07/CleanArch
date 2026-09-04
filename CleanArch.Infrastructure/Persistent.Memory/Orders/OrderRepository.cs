using CleanArch.Domain.Orders;
using CleanArch.Domain.Orders.Repository;

namespace CleanArch.Infrastructure.Persistent.Memory.Orders;

public class OrderRepository: IOrderRepository
{
    private Context _context;

    public OrderRepository(Context context)
    {
        _context = context;
    }
    public List<Order> GetList()
    {
        return _context.Orders;
    }

    public Order GetById(long id)
    {
        return _context.Orders.FirstOrDefault(x => x.Id == id);
    }

    public void Add(Order order)
    {
        _context.Orders.Add(order);
    }

    public void Update(Order order)
    {
        var existingOrder = GetById(order.Id);

        _context.Orders.Remove(existingOrder);
        _context.Orders.Add(order);
    }

    public void SaveChanges()
    {
        //TODO: Implement SaveChanges logic
    }
}