public class Quadrant
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the x coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if(x > 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant 1");
        }
        else if(x < 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant 2");
        }
        else if(x < 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant 3");
        }
        else if(x > 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant 4");
        }
        else
        {
            Console.WriteLine("The point is on the axis");
        }
    }
}