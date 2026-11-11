Console.WriteLine("Enter 1st number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine($"{num1} and {num2} are equal");
}
else
{
    Console.WriteLine($"{num1} and {num2} are not equal");
}