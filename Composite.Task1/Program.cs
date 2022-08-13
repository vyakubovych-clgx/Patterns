using Composite.Task1;

var root = new InputText("root", "input 1");
var level1Input1 = new InputText("level 1", "input 1");
var level11Input1 = new InputText("level 1.1", "input 1");
var level11Label1 = new LabelText("level 1.1 label 1");
var level11Label2 = new LabelText("level 1.1 label 2");
var level11Input2 = new InputText("level 1.1", "input 2");
var level111Input1 = new InputText("level 1.1.1", "input 1");
var level1Label1 = new LabelText("level 1 label 1");
var level1Input2 = new InputText("level 1", "input 2");
var level12Label1 = new LabelText("level 1.2 label 1");

level11Input1.Add(level111Input1);

level1Input1.Add(level11Input1);
level1Input1.Add(level11Label1);
level1Input1.Add(level11Label2);
level1Input1.Add(level11Input2);

level1Input2.Add(level12Label1);

root.Add(level1Input1);
root.Add(level1Label1);
root.Add(level1Input2);

Console.WriteLine(root.ConvertToString());
Console.ReadLine();
