using System;

public class Billing
{
    public static void Main(string[] args)
    {
        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();

        Console.Write("Enter product quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter product price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        double total = quantity * price;

        double discount = 0;

        if (total > 5000)
        {
            discount = total * 0.18;
        }

        double finalPrice = total - discount;

        double gst = finalPrice * 0.12;

        double billAmount = finalPrice + gst;

        Console.WriteLine("\n----- BILL -----");
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Price per Product: " + price);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Price after Discount: " + finalPrice);
        Console.WriteLine("GST (12%): " + gst);
        Console.WriteLine("Final Bill Amount: " + billAmount);
    }
}