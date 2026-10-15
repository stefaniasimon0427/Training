public class CountOfDigits
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while(num > 0)
        {
            count++;
            num /= 10;
        }
        Console.WriteLine("The count of the digits is: " + count);
    }
}