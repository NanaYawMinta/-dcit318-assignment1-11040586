using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Ticket Price Calculator");
        Console.Write("Enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            decimal ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7.00m; // Discounted price
            }
            else
            {
                ticketPrice = 10.00m; // Regular price
            }

            Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
