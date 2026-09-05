using CleanArch.Application.Products.DTOs;
using CleanArch.Domain.Products;
using CleanArch.Domain.Products.Repository;
using CleanArch.Domain.Shared;

namespace CleanArch.Application.Products;

public class ProductService: IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public void AddProduct(AddProductDto command)
    {
        var product = new Product(command.Title, Money.FromRial(command.Price));
        _productRepository.Add(product);
        _productRepository.SaveChanges();
    }

    public void EditProduct(EditProductDto command)
    {
        var product = _productRepository.GetById(command.Id);
        product.Edit(command.Title, Money.FromRial(command.Price));
        _productRepository.Update(product);
        _productRepository.SaveChanges();
    }

    public ProductDto GetProductById(Guid id)
    {
        var product = _productRepository.GetById(id);
        return new ProductDto
        {
            Id = product.Id,
            Title = product.Title,
            Price =  product.Price.Value
        };
    }

    public List<ProductDto> GetProducts()
    {
        var products = _productRepository.GetList();
        return products.Select(p => new ProductDto
        {
            Id = p.Id,
            Title = p.Title,
            Price = p.Price.Value
        }).ToList();
    }
}