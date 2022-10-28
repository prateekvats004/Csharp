using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int decrease = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= decrease; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                decrease--;
            }
        }
    }
}
