// Assignment 1.1.1 
//1. Create a console application in C# to store and print personal details of a person like name, age and address on console screen. Make use of appropriate variables. 

Console.WriteLine("Please enter full name: ");
string name = Console.ReadLine();

Console.WriteLine("Please enter age: ");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter address: ");
string address = Console.ReadLine();

Console.WriteLine("Personal Details");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Address: {address}");
