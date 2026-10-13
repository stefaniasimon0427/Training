public class Odd
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=num; i++)
        {
            if(i%2!=0)
            {
                Console.WriteLine(i);
            }
        }
    }
}