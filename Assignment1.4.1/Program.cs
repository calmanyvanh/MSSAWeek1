//Assignment 1.4.1
//Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. 
//Determine if P2 is to the right or left of P1 or on same axis , by comparing the x coordinates.
//( if p1.x is more than p2.x , it is to the right )

struct Point
{
    public int xCoord;
    public int yCoord;

    public Point(int xCoord, int yCoord)
    {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    }
}

class Program
{
    static void Main()
    {
        Point P1 = new Point(0, 0);
        Point P2 = new Point(0, 0);

        Console.Write("Enter X coordinate for P1: ");
        P1.xCoord = int.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate for P1: ");
        P1.yCoord = int.Parse(Console.ReadLine());

        Console.Write("Enter X coordinate for P2: ");
        P2.xCoord = int.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate for P2: ");
        P2.yCoord = int.Parse(Console.ReadLine());

        if (P1.xCoord > P2.xCoord)
        {
            Console.WriteLine("P1 is to the right of P2.");
        }
        else if (P1.xCoord < P2.xCoord)
        {
            Console.WriteLine("P1 is to the left of P2.");
        }
        else
        {
            Console.WriteLine("P1 and P2 are on the same vertical axis.");
        }
    }
}