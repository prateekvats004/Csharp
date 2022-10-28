using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int decrease = 4;
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= decrease; k++)
                {
                    Console.Write(" ");
                }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                
                Console.WriteLine();
                decrease--;
            }
        }
    }
}
