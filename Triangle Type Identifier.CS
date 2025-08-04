using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Triangle Type Identifier");

        Console.Write("Enter side A: ");
        bool validA = double.TryParse(Console.ReadLine(), out double a);

        Console.Write("Enter side B: ");
        bool validB = double.TryParse(Console.ReadLine(), out double b);

        Console.Write("Enter side C: ");
        bool validC = double.TryParse(Console.ReadLine(), out double c);

        if (validA && validB && validC && a > 0 && b > 0 && c > 0)
        {
            // Check if sides can form a triangle using triangle inequality
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("The triangle is Equilateral.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("The triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The triangle is Scalene.");
                }
            }
            else
            {
                Console.WriteLine("These sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid positive numbers.");
        }
    }
}
