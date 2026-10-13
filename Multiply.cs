public class Multiply
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<=12 ; i++)
        {
            Console.WriteLine(num * i);
            
        }
    }
}