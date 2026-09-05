using CleanArch.Domain.Shared;

namespace CleanArch.Domain.Products;

public class Product
{
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public Money Price { get; private set; }

    public Product(string title, Money price)
    {
        Guard(title);

        Id = Guid.NewGuid();
        Title = title;
        Price = price;
    }

    public void Edit(string title, Money price)
    {
        Guard(title);
        Title = title;
        Price = price;
    }
    private void Guard(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentNullException(nameof(title));
    }

}

