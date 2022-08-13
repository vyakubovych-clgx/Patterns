using Facade.Task.Interfaces;
using Facade.Task.Models;

namespace Facade.Task.Implementations;

public class OrderFacade : IOrderFacade
{

    private readonly IProductCatalog _productCatalog;
    private readonly IPaymentSystem _paymentSystem;
    private readonly IInvoiceSystem _invoiceSystem;

    public OrderFacade(IProductCatalog productCatalog,
        IPaymentSystem paymentSystem,
        IInvoiceSystem invoiceSystem)
    {
        _productCatalog = productCatalog;
        _paymentSystem = paymentSystem;
        _invoiceSystem = invoiceSystem;
    }

    public void PlaceOrder(string productId, int quantity, string email)
    {
        var product = _productCatalog.GetProductDetails(productId);
        var totalPrice = product.Price * quantity;
        var payment = new Payment(email, totalPrice);
        if (!_paymentSystem.MakePayment(payment)) 
            return;
        var invoice = new Invoice(email, totalPrice);
        _invoiceSystem.SendInvoice(invoice);
    }
}