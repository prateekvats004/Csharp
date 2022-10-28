using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 5; i++)
            {
                int add = 1;
                for (int j = 1; j <= 9; j++)
                {
                    if ((i + j) <= 5)
                    {
                        Console.Write(" ");
                    }
                    else if ((j - i) >= 5)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(add);
                        if (j < 5)
                            add++;
                        else
                            add--;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
