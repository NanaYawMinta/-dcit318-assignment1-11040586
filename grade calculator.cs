using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("Enter your numerical grade (0 - 100): ");

        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            string letterGrade;

            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else if (grade >= 0)
                letterGrade = "F";
            else
                letterGrade = "Invalid";

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number.");
        }
    }
}
