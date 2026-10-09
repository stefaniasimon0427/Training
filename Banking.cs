public class Bank
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your ATM PIN: ");
        int pin = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your account balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your account balance is: " + balance);
        Console.WriteLine("Choose whether you'd like to deposit or withdraw: ");
        string choice = Console.ReadLine();
        Console.WriteLine("Enter the amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the mode of payment (UPI, cash, cheque: ");
        string mode = Console.ReadLine();
        if (choice.ToLower() == "deposit")
        {
            balance += amount;
            Console.WriteLine("Your new account balance is: " + balance + " through " + mode);
        }
        else if (choice.ToLower() == "withdraw")
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Your new account balance is: " + balance + " through " + mode);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}