using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double division = 0;
        double modulus = 0;

        if (num2 != 0)
        {
            division = num1 / num2;
            modulus = num1 % num2;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero!");
        }

        Console.WriteLine("\nResults:");
        Console.WriteLine("Addition = " + sum);
        Console.WriteLine("Subtraction = " + difference);
        Console.WriteLine("Multiplication = " + product);
        Console.WriteLine("Decimal Multiplication = " + product);
        Console.WriteLine("Division = " + division);
        Console.WriteLine("Modulus = " + modulus);
    }
}