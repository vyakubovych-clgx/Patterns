using Facade.Task.Interfaces;
using Facade.Task.Models;

namespace Facade.Task.Implementations;

public class InvoiceSystem : IInvoiceSystem
{
    public void SendInvoice(Invoice invoice)
    {
        Console.WriteLine($"Invoice was sent to {invoice.Email}");
    }
}