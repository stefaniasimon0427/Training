public class SumOfDigits
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("The sum of the digits is: " + sum);
    }
}