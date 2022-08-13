using Adapter.Task;

var elements = new Elements<int>(new [] {1,2,3,4,5});
var adapter = new Adapter<int>(elements);
var printer = new Printer();
printer.Print(adapter);
Console.ReadLine();