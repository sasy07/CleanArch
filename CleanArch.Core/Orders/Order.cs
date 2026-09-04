using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Orders;

public class Order
{
    public long Id { get; private set; }
    public Guid ProductId { get; private set; }
    public int Count { get; private set; }
    public int Price { get; private set; }
    public int TotalPrice => Count*Price;
    public bool IsFinally { get; private set; }
    public DateTime FinallyDate { get; private set; }


    public Order(Guid productId, int count, int price)
    {
        if (count < 1) throw new ArgumentOutOfRangeException(nameof(count));
        if(price < 0) throw new ArgumentOutOfRangeException(nameof(price));

        ProductId = productId;
        Count = count;
        Price = price;

    }

    public void Finally()
    {
        IsFinally = true;
        FinallyDate = DateTime.Now;
    }
    public void IncreaseProductCount(int count)
    {
        if(count < 1) throw new ArgumentOutOfRangeException(nameof(count));
        Count += count;
    }
}

