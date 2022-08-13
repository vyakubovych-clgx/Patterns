using Composite.Task2;

var root = new Form("root");
var level1Form1 = new Form("level 1 form 1");
var level11Form1 = new Form("level 1.1 form 1");
var level111Input1 = new InputText("level 1.1.1", "input 1");
var level11Input1 = new InputText("level 1.1", "input 1");
var level11Label1 = new LabelText("level 1.1 label 1");
var level11Form2 = new Form("level 1.1 form 2");
var level1Label1 = new LabelText("level 1 label 1");
var level1Form2 = new Form("level 1 form 2");
var level12Label1 = new LabelText("level 1.2 label 1");

level11Form1.Add(level111Input1);

level1Form1.Add(level11Form1);
level1Form1.Add(level11Input1);
level1Form1.Add(level11Label1);
level1Form1.Add(level11Form2);

level1Form2.Add(level12Label1);

root.Add(level1Form1);
root.Add(level1Label1);
root.Add(level1Form2);

Console.WriteLine(root.ConvertToString());
Console.ReadLine();