namespace CleanArch.Domain.Products.Repository;

public interface IProductRepository
{
    List<Product> GetList();
    Product GetById(Guid id);
    void Add(Product product);
    void Update(Product product);
    void Remove(Product product);
    void SaveChanges();
}