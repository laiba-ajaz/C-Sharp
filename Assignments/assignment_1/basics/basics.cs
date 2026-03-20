using System;

class Program
{
    static void Main()
    {
        // even / odd checker
        Console.WriteLine("Enter any number to check whether a number is even or odd");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }


        // prime number checker
        Console.WriteLine("Enter a number to check whether it is prime or not:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
        {
            Console.WriteLine($"{n} is not a prime number");
            return;
        }

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;  
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{n} is a prime number");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number");
        }


        //leap year 
        Console.WriteLine("Enter year to check whether is a leap year or not ?");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }


        // factorial
        Console.WriteLine("Enter number to find factorial");
        int num = Convert.ToInt32(Console.ReadLine());

        int fact = 1;

        for (int i = 1; i <= num; i++)
        {
            fact = fact * i;
        }

        Console.WriteLine($"Factorial of {num} is {fact}");
        

        //marksheet
        int statistics = 89;
        int eng = 80;
        int urdu = 79;
        int accounting = 92;
        int pst = 45;
        int commercial_geography = 69;
        int banking = 73;
        int totalMarks = 550;
        int obtainedMarks = statistics + eng + urdu + accounting + pst + commercial_geography + banking;
        double percentage = ((double)obtainedMarks / totalMarks) * 100;

        string grade;

        if (percentage >= 80)
        {
            grade = "A-1";
        }
        else if (percentage >= 70)
        {
            grade = "A";
        }
        else if (percentage >= 60)
        {
            grade = "B";
        }
        else if (percentage >= 50)
        {
            grade = "C";
        }
        else
        {
            grade = "Fail";
        }

        Console.WriteLine($"Grade: {grade}");



        //calculator
        Console.WriteLine("Enter first number");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /)");
        string opr = Console.ReadLine();

        Console.WriteLine("Enter second number");
        int b = Convert.ToInt32(Console.ReadLine());

        switch (opr)
        {
            case "+":
                Console.WriteLine( $"The result is {a + b}");
                break;

                case "-":
                Console.WriteLine($"The result is {a - b}");
                break;

                case "*":
                Console.WriteLine($"The result is {a * b}");
                break;

                case "/":
                Console.WriteLine($"The result is {a / b}");
                break;

            default:
                Console.WriteLine("Please enter valid operator");
                break;

        }
        



    }
}

