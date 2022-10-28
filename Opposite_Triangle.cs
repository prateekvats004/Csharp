using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many line of patteren you want ?");
            int num = Convert.ToInt32(Console.ReadLine());
            int num_j = num + (num - 1);
            for (int i = 1; i <= num; i++)
             
            {
                int add = 1;
                for (int j = 1; j <= num_j; j++)
                {
                    if ((i + j) >= (num_j + 2))
                    {
                        Console.Write(" ");
                    }
                    else if (i > j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(add);
                        if (j < num)
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

