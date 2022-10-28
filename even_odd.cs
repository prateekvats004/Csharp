using System;
using System.Linq;


namespace MyApplication
{
    class Program
    {
        static void EnterNo()
        {
            char yes = 'y';
            while (yes == 'y' || yes == 'Y')
            {
                Console.WriteLine("EnterNo a number");
                int num = Convert.ToInt32(Console.ReadLine());      
                if (num % 2 == 1)
                {
                    Console.WriteLine("You entered a Odd number.");
                }
                else
                {
                    Console.WriteLine("You entered a even number.");
                }
                Console.WriteLine("Do you want to continue ?");
                Console.WriteLine("(Press y or Y to continue)");
                yes = Convert.ToChar(Console.ReadLine());
            }
            
        }
    
        
        static void Main(string[] args)
        {
            EnterNo();
        }
    }
}