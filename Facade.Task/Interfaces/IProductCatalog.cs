using Facade.Task.Models;

namespace Facade.Task.Interfaces;

public interface IProductCatalog
{
    Product GetProductDetails(string productId);
}