bool calculating = true;
while (calculating)
{
    Console.WriteLine("Area calculator menu: ");
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Rectangle");
    Console.WriteLine("4. Exit");
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("You chose Triangle.");
            Console.WriteLine("Enter base: ");
            int bottom = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine($"The area is: {0.5 * bottom * height}");

            break;

        case "2":
            Console.WriteLine("You chose Square.");
            Console.WriteLine("Enter side length: ");
            int side = int.Parse(Console.ReadLine());

            Console.WriteLine($"The area is: {side * side}");

            break;

        case "3":
            Console.WriteLine("You chose Rectangle.");
            Console.WriteLine("Enter length: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine($"The area is: {length * width}");

            break;

        case "4":
            calculating = false;
            Console.WriteLine("Exiting calculator.");

            break;

    }
}