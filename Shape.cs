public class Shape
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                if (i == 1 || i == rows / 2 + 1 || i == rows)
                {
                    Console.Write("*");
                }
                else if (i < rows / 2 + 1 && j == 1)
                {
                    Console.Write("*");
                }
                else if (i > rows / 2 + 1 && j == columns)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}