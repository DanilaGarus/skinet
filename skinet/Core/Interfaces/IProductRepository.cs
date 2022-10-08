using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    Task<Products> GetProductsByIdAsync(int id);
    Task<IReadOnlyList<Products>> GetProductsAsync();
    Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
}