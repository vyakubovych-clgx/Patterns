namespace Facade.Task.Interfaces;

public interface IOrderFacade
{
    void PlaceOrder(string productId, int quantity, string email);
}