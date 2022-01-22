using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
             int a = 3333;
             if(a>=1000 && a < 10000)
             {
                    a = 70000 + a; //73333
                 a = a * 10;         //733330
                 a = a + 8;          //733338
                 Console.WriteLine(a);
             }
             else
             {
                 //yanlis hal
                 Console.WriteLine("4 reqemli deyil");

             }
           
            

        } 

    }
}
