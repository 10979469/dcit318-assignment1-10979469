using System;

class Program
{
    static void Main()
    {
        // Create an instance of the TicketPriceCalculator class
        TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();

        // Prompt the user for their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Calculate and display the ticket price
        string result = ticketPriceCalculator.CalculateTicketPrice(input);
        Console.WriteLine(result);
    }
}

public class TicketPriceCalculator
{
    // Method to calculate the ticket price based on the age
    public string CalculateTicketPrice(string input)
    {
        int age;

        // Check if the input is a valid integer
        if (int.TryParse(input, out age))
        {
            // Check if the age is within a valid range
            if (age >= 0)
            {
                // Determine the ticket price based on the age
                int ticketPrice;
                if (age <= 12 || age >= 65)
                {
                    ticketPrice = 7; // Discounted price for children and senior citizens
                }
                else
                {
                    ticketPrice = 10; // Regular price for others
                }

                // Return the ticket price
                return "The ticket price is: GHC" + ticketPrice;
            }
            else
            {
                return "Please enter a valid age.";
            }
        }
        else
        {
            return "Invalid input. Please enter a numerical age.";
        }
    }
}