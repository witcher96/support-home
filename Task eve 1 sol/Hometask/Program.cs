using System;

namespace Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 54321;
            int cem = 0;
            int hasil=1; ;
            int qaliq;
            int qaliq2;
            int qaliq3;
            int netice;
            int yekun_netice;
            if (a >= 10000 && a < 100000)
            {
                while (a > 0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;
                }
                Console.WriteLine(cem);
            }
            if (b>= 10000 && b < 100000)
            {
            while (b > 0)
            {
                qaliq2 = b % 10;
                b = (b - qaliq2) / 10;
                hasil = (hasil*qaliq2);
            }
            Console.WriteLine(hasil);
            }
            netice = cem + hasil;
            Console.WriteLine(netice);

            qaliq3 = cem % 10;
            yekun_netice = (netice * 10) + qaliq3;
            Console.WriteLine(yekun_netice);
        }   
    }
}
