using System;
using System.Linq;
class Programs
{static void Main()
    {
        // number patern
        for (int i = 1; i <= 5; i++)
        {

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }

        // * pattern 
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
          //length function 
        String[] names = { "Hania", "Sana", "Farah", "Alina", "Mishkat", "Arhama", " Muskaan", "Fabeeha", "Nada", "Khizra" };
        int ArrayLength = names.Length;
        Console.WriteLine ($"The length of an array is {ArrayLength}");


        // maximun / minimum function
        int[] salaries = { 45000, 85000, 32000, 90000, 25000 };
        int MaxValue = salaries.Max();
        int MinValue = salaries.Min();
        Console.WriteLine($"The maximum value is {MaxValue}");
        Console.WriteLine($"The maximum value is {MinValue}");


        // average by using for each loop
        int[] marks = { 78, 82, 55, 66, 79, 90, 69 };
        int marksLength = marks.Length;
        double sum = 0;
        foreach (int m in marks)
        {
            sum += m; 
        }
        double average = sum / marksLength;
        Console.WriteLine($"The average of the marks is {average}");



        // sum program by using loop
        int[] marks = { 10, 34, 18, 43 };
        int sum = 0;
        for (int i = 0; i < marks.Length;  i++)
        {
         sum = sum + marks[i];
        }
        Console.WriteLine($"Total sum by using loop is {sum}");
    }
}