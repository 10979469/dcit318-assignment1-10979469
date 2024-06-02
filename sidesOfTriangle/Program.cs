using System;

class Program
{
    static void Main()
    {
        // Create an instance of the Triangle class
        Triangle triangle = new Triangle();

        // Prompt the user for the lengths of the sides
        Console.Write("Enter the length of side 1: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the length of side 2: ");
        string input2 = Console.ReadLine();

        Console.Write("Enter the length of side 3: ");
        string input3 = Console.ReadLine();

        // Determine and display the type of the triangle
        string result = triangle.DetermineTriangleType(input1, input2, input3);
        Console.WriteLine(result);
    }
}

public class Triangle
{
    // Method to determine the type of the triangle based on the lengths of its sides
    public string DetermineTriangleType(string input1, string input2, string input3)
    {
        double side1, side2, side3;

        // Check if the inputs are valid double numbers
        if (double.TryParse(input1, out side1) && double.TryParse(input2, out side2) && double.TryParse(input3, out side3))
        {
            // Check if the sides form a valid triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                // Determine the type of the triangle
                if (side1 == side2 && side2 == side3)
                {
                    return "The triangle is Equilateral.";
                }
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    return "The triangle is Isosceles.";
                }
                else
                {
                    return "The triangle is Scalene.";
                }
            }
            else
            {
                return "The entered sides do not form a valid triangle.";
            }
        }
        else
        {
            return "Invalid input. Please enter numerical values for the sides.";
        }
    }

    // Method to check if the sides form a valid triangle
    private bool IsValidTriangle(double side1, double side2, double side3)
    {
        return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
    }
}