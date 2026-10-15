public class Prime
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;
        for(int i = 2; i <= num / 2; i++)
        {
            if(num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "The number is prime." : "The number is not prime.");
    }
}