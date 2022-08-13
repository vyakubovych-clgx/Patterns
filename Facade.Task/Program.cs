using Facade.Task.Implementations;

var orderFacade = new OrderFacade(new ProductCatalog(), new PaymentSystem(), new InvoiceSystem());
orderFacade.PlaceOrder("potato", 10, "viktor_yakubovych@epam.com");
Console.ReadLine();