using System;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
    class PrintASequence
    {
        static void Main()
        {
            int v = -5;
            int temp = 2;
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine(temp);
                temp = temp + v;
                if (v < 0)
                {
                    v = v * (-1) + 2;
                }
                else
                {
                    v = v * (-1) - 2;
                }

            }
        }
    }

