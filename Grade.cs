public class Grade
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter your total score: ");
        int totalscore = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your score: ");
        int yourscore = Convert.ToInt32(Console.ReadLine());
        double percentage = (double)yourscore / (double)totalscore * 100;
        if(percentage >= 95)
        {
            Console.WriteLine("Your grade is S");
        }
        else if(percentage >= 90)
        {
            Console.WriteLine("Your grade is A");
        }
        else if(percentage >= 80)
        {
            Console.WriteLine("Your grade is B");
        }
        else if(percentage >= 70)
        {
            Console.WriteLine("Your grade is C");
        }
        else if(percentage >= 60)
        {
            Console.WriteLine("Your grade is D");
        }
        else if(percentage >= 50)
        {
            Console.WriteLine("Your grade is E");
        }
        else if(percentage <= 40)
        {
            Console.WriteLine("Your grade is F");
        }
    }
}