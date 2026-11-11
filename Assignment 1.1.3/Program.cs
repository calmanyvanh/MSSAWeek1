Console.WriteLine("Enter dividend: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter divisor: ");
int num2 = int.Parse(Console.ReadLine());

int quotient = num1 / num2;
int remainder = num1 % num2;

Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");