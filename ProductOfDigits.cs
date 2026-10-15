public class ProductOfDigits
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int product = 1;
        while(num > 0)
        {
            product *= num % 10;
            num /= 10;
        }
        Console.WriteLine("The product of the digits is: " + product);
    }
}