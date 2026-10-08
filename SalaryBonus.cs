public class SalaryBonus
{
    public static void Main(string[] args)
    {
        int salary = 50000;
        int totalWorkingDays = 26;
        int newsalary = salary;
        double bonus = 0;
        Console.WriteLine("Enter your working days: ");
        int days = Convert.ToInt32(Console.ReadLine());
        if(days < 26)
        {
            newsalary = salary * days / totalWorkingDays;
            Console.WriteLine("Your new salary is: {0}", newsalary);
        }
        Console.WriteLine("Enter your working years:");
        int years = Convert.ToInt32(Console.ReadLine());
        if(years == 1)
        {
            bonus = bonus + 0.02 * (double)salary;
            Console.WriteLine("Your bonus is: {0}", bonus);
        }
        else if(years == 3)
        {
            bonus = bonus + 0.05 * (double)salary;
            Console.WriteLine("Your bonus is: {0}", bonus);
        }
        else if(years == 5)
        {
            bonus = bonus + 0.1 * (double)salary;
            Console.WriteLine("Your bonus is: {0}", bonus);
        }
        else
        {
            Console.WriteLine("No bonus");
        }
        Console.WriteLine("Your total salary is: {0}", (double)newsalary + bonus);
    }
}