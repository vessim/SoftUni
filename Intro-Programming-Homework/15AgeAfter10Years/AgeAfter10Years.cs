using System;
//Write a program to read your age from the console and print how old you will be after 10 years.
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("What's your age");
            int age = int.Parse(Console.ReadLine());
            int ageAfter10Years = age + 10;
            Console.WriteLine("Your age after 10 years will be {0}",ageAfter10Years);
        }
    }

