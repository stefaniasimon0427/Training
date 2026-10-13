public class Triangle
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num * j + " ");
            }
            Console.WriteLine();
        }
    } 
} 