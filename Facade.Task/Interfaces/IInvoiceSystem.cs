using Facade.Task.Models;

namespace Facade.Task.Interfaces;

public interface IInvoiceSystem
{
    void SendInvoice(Invoice invoice);
}