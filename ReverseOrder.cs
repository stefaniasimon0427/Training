public class Reverse
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i=number; i>=1; i--)
        {
            Console.WriteLine(i);
        }
    }
}