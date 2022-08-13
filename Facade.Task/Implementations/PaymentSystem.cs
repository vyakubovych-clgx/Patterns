using Facade.Task.Interfaces;
using Facade.Task.Models;

namespace Facade.Task.Implementations;

public class PaymentSystem : IPaymentSystem
{
    public bool MakePayment(Payment payment)
    {
        var success = Random.Shared.Next(2) == 0;
        Console.WriteLine(success
            ? $"Payment from {payment.PayerEmail} of {payment.Amount} was accepted."
            : $"Payment system doesn't like {payment.PayerEmail} and won't accept the payment!");
        return success;
    }
}