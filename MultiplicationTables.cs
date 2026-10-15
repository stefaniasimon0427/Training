public class Tables
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Multiplication Table of " + num + ":");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}