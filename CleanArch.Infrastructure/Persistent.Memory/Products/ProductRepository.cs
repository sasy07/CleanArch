using CleanArch.Domain.Products;
using CleanArch.Domain.Products.Repository;

namespace CleanArch.Infrastructure.Persistent.Memory.Products;

public class ProductRepository : IProductRepository
{
    private Context _context;
    private List<Product> _products;

    public ProductRepository(Context context)
    {
        _context = context;
        _products = new List<Product>();
    }
    public List<Product> GetList()
    {
        return _context.Products;
    }

    public Product GetById(Guid id)
    {
        return _context.Products.FirstOrDefault(p => p.Id == id);
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
    }

    public void Update(Product product)
    {
        var existingProduct = GetById(product.Id);

        _context.Products.Remove(existingProduct);
        _context.Products.Add(product);


    }

    public void Remove(Product product)
    {
        _context.Products.Remove(product);
    }

    public void SaveChanges()
    {
        //TODO: Implement SaveChanges logic
    }
}