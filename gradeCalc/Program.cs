using System;

class Program
{
    static void Main()
    {
        // Create an instance of the GradeCalculator class
        GradeCalculator gradeCalculator = new GradeCalculator();

        // Prompt the user for a grade
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();

        // Calculate and display the letter grade
        string result = gradeCalculator.CalculateLetterGrade(input);
        Console.WriteLine(result);
    }
}

public class GradeCalculator
{
    // Method to calculate the letter grade based on the numerical grade
    public string CalculateLetterGrade(string input)
    {
        int grade;

        // Check if the input is a valid integer
        if (int.TryParse(input, out grade))
        {
            // Check if the input is within the valid range
            if (grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade;
                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Return the letter grade
                return "The letter grade is: " + letterGrade;
            }
            else
            {
                return "Please enter a grade between 0 and 100.";
            }
        }
        else
        {
            return "Invalid input. Please enter a numerical grade.";
        }
    }
}