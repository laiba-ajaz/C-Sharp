
using System;

class Program
{
    static void Main()
    {
        // data types 
        String name = "Laiba";
        int age = 19;
        double gpa = 3.8;
        Boolean isStudent = true;

        // printing the data
        Console.WriteLine($"Name :{name}");
        Console.WriteLine($"Age:{age}");
        Console.WriteLine($"GPA :{gpa}");
        Console.WriteLine($"Is Student :{isStudent}");


        //array 
        String[] names = { "Laiba", "Haleema", "Ayesha", "Umaima" };
        Console.WriteLine(names[1]);

        //loops
        foreach (String n in names)
        {
            Console.WriteLine($"Hello , {n}");
        }

        //while loop
        int i = 0;
        while (i <= 20)
        {
            Console.WriteLine(i);
            i++;
        }

        int[] Marks = { 45, 38, 76, 89, 90 };
        foreach (int marks in Marks)
        {
            if (marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }

        Console.WriteLine("Enter your name:");
        String UserName = Console.ReadLine();
        Console.WriteLine($"Hello, {UserName}!");
        Console.WriteLine("Enter your age:");
        int UserAge = Console.ReadLine();
        Console.WriteLine($"Your name is {UserName} and your age is {UserAge}");
    }
}
