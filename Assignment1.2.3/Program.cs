bool calculating = true;
while (calculating)
{
    Console.WriteLine("Calculator menu: ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("You chose Addition.");
            Console.WriteLine("Enter 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum is: {num1 + num2}");

            break;

        case "2":
            Console.WriteLine("You chose Subtraction.");
            Console.WriteLine("Enter 1st number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The difference is: {num3 - num4}");

            break;

        case "3":
            Console.WriteLine("You chose Multiplication.");
            Console.WriteLine("Enter 1st number: ");
            int num5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            int num6 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The product is: {num5 * num6}");

            break;

        case "4":
            Console.WriteLine("You chose Division.");
            Console.WriteLine("Enter dividend: ");
            int num7 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter divisor: ");
            int num8 = int.Parse(Console.ReadLine());

            if (num8 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                break;
            }
            else
            { 
            int quotient = num7 / num8;
            int remainder = num7 % num8;
            Console.WriteLine($"Quotient is: {quotient} and remainder is: {remainder}");
            }
            break;

        case "5":
            calculating = false;
            Console.WriteLine("Exiting calculator.");
            break;
    }

}