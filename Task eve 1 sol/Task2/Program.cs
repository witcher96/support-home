using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 3;
            if (a < 10 && a>0)
            {
                a = a + a;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Tekreqemli deyil");
            }

        }
    }
}
