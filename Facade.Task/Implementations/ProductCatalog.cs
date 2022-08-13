using Facade.Task.Interfaces;
using Facade.Task.Models;

namespace Facade.Task.Implementations;

public class ProductCatalog : IProductCatalog
{
    private readonly IEnumerable<Product> _products = new List<Product>
    {
        new("tomato", "Tomato", 4),
        new("cucumber", "Cucumber", 3.5m),
        new("potato", "Potato", 2)
    };

    public Product GetProductDetails(string productId)
        => _products.FirstOrDefault(p => p.Id == productId);
}