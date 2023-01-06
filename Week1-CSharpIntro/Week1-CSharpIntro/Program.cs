// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string name = "Eric";

Console.WriteLine($"Hi there {name}");
Console.WriteLine("Hi there " + name);

string yourName = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Hi there {yourName}");

SomeFunction();

void SomeFunction()
{
    Console.WriteLine("some function");
}
