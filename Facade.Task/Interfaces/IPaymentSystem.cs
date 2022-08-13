using Facade.Task.Models;

namespace Facade.Task.Interfaces;

public interface IPaymentSystem
{
    bool MakePayment(Payment payment);
}