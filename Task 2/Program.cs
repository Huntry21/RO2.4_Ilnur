using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select Exercise (1-7):");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter first number: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double n2 = Convert.ToDouble(Console.ReadLine());

                if (n1 > n2)
                {
                    Console.WriteLine("The first number is greater");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine("The second number is greater");
                }
                else
                {
                    Console.WriteLine("The numbers are equal");
                }
                break;

            case 2:
                Console.Write("Enter number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                if (num2 > 5 && num2 < 10)
                {
                    Console.WriteLine("The number is greater than 5 and less than 10");
                }
                else
                {
                    Console.WriteLine("Unknown number");
                }
                break;

            case 3:
                Console.Write("Enter number: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                if (num3 == 5 || num3 == 10)
                {
                    Console.WriteLine("The number is either 5 or 10");
                }
                else
                {
                    Console.WriteLine("Unknown number");
                }
                break;

            case 4:
                Console.Write("Enter deposit amount: ");
                double sum4 = Convert.ToDouble(Console.ReadLine());
                if (sum4 < 100)
                {
                    sum4 += sum4 * 0.05;
                }
                else if (sum4 >= 100 && sum4 <= 200)
                {
                    sum4 += sum4 * 0.07;
                }
                else
                {
                    sum4 += sum4 * 0.10;
                }
                Console.WriteLine("Amount with interest: " + sum4);
                break;

            case 5:
                Console.Write("Enter deposit amount: ");
                double sum5 = Convert.ToDouble(Console.ReadLine());
                if (sum5 < 100)
                {
                    sum5 += sum5 * 0.05;
                }
                else if (sum5 >= 100 && sum5 <= 200)
                {
                    sum5 += sum5 * 0.07;
                }
                else
                {
                    sum5 += sum5 * 0.10;
                }
                sum5 += 15;
                Console.WriteLine("Amount with interest and bonus: " + sum5);
                break;

            case 6:
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication");
                int op6 = Convert.ToInt32(Console.ReadLine());
                switch (op6)
                {
                    case 1: Console.WriteLine("Addition"); break;
                    case 2: Console.WriteLine("Subtraction"); break;
                    case 3: Console.WriteLine("Multiplication"); break;
                    default: Console.WriteLine("Operation is undefined"); break;
                }
                break;

            case 7:
                Console.WriteLine("1.Addition 2.Subtraction 3.Multiplication");
                int op7 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Num 1: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Num 2: ");
                double y = Convert.ToDouble(Console.ReadLine());
                switch (op7)
                {
                    case 1: Console.WriteLine("Result: " + (x + y)); break;
                    case 2: Console.WriteLine("Result: " + (x - y)); break;
                    case 3: Console.WriteLine("Result: " + (x * y)); break;
                    default: Console.WriteLine("Operation is undefined"); break;
                }
                break;

            default:
                Console.WriteLine("Invalid selection");
                break;
        }
    }
}