

using System;

class Program
{
    static void Main()
    {
        double num_1, num_2, result = 0;

        Console.Write("Enter first number: ");
        num_1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char opr = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        num_2 = Convert.ToDouble(Console.ReadLine());

        if (opr == '+')
        {
            result = num_1 + num_2;
        }
        else if (opr == '-')
        {
            result = num_1 - num_2;
        }
        else if (opr == '*')
        {
            result = num_1 * num_2;
        }
        else if (opr == '/')
        {
            if (num_2 != 0)
                result = num_1 / num_2;
            else
            {
                Console.WriteLine("Error: Cannot divide by zero!");

            }
        }
        else
        {
            Console.WriteLine("Error: Invalid operator!");

        }
        Console.WriteLine("Result: " + result);
    }
}

