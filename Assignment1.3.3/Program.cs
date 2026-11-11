
Console.Write("Input the number of elements to store in the array: ");

int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Element {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The values stored into the array are: ");

for (int i = 0; i < n; i++)
{
    
   Console.Write(arr[i] + " ");
}

Console.WriteLine("\nThe values stored into the array in reverse are: ");

foreach (int element in arr.Reverse())
{
    Console.Write(element + " ");
}
