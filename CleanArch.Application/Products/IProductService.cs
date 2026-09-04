using CleanArch.Application.Products.DTOs;

namespace CleanArch.Application.Products;

public interface IProductService
{
    void AddProduct(AddProductDto command);
    void EditProduct(EditProductDto command);
    ProductDto GetProductById(Guid id);
    List<ProductDto> GetProducts();
}