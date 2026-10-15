public class Perfect
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i = 1; i < num; i++)
        {
            if(num % i == 0)
            {
                sum+=i;
            
            }
        }
        if(sum == num)
        {
            Console.WriteLine("The number is perfect.");
        }
        else if(sum > num)
        {
            Console.WriteLine("The number is abundant.");
        }
        else if (num < sum)
        {
            Console.WriteLine("The number is deficient.");
        }
        else
        {
            Console.WriteLine("The number is neither perfect, abundant, nor deficient.");
        }
        
    }
}