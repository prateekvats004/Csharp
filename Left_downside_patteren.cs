using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int decrese = 5;
           for (int i =1; i <= 5; i++)
            {
                for(int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<=decrese; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                decrese--;
            }
        }
    }
}
