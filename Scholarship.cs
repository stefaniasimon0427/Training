public class Program
{
    public static void Main(string[] args)
    {
        int fees = 100000;
        Console.WriteLine("Enter your mark percent: ");
        int mark = Convert.ToInt32(Console.ReadLine());
        if(mark > 90)
        {
            Console.WriteLine("Eligible for scholarship");
            double newfees = (double)fees - 0.5 * (double)fees;
            Console.WriteLine("Your new fees are: {0}", newfees);
        }
        else
        {
            Console.WriteLine("Not eligible for scholarship");
        }
    }
}

