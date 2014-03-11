using System;
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops (search in Internet).
    class PrintLongSequence
    {
        static void Main()
        {
            Console.BufferHeight = 1100;
            int num = 2;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(num);
                if (i % 2 == 0)
                {
                    num = (num + 1) * (-1);
                }
                else
                {
                    num = (num - 1) * (-1);
                }
            }
        }
    }

