using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            var even = new List<int>();
            var odd = new List<int>();
            Console.WriteLine("How many numbers you want to enter ?");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter Number = ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                if (num % 2 == 1)
                {
                    odd.Add(num);
                }
                else 
                {
                    even.Add(num);
                }
            }
            Console.WriteLine("sum = " + sum);
            Console.Write("odd = ");
            foreach (int i in odd)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.Write("even = ");
            foreach (int i in even)
            {
                Console.Write(i + ",");
            }
        }
    }
}
