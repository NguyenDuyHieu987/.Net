using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class Program
    {
        static void GPTB1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("Nhap a= ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap b= ");
            float b = System.Single.Parse(Console.ReadLine());

            if (b != 0)
            {
                Console.WriteLine($"{a}x + {b} = {(-b) / a}");
            }
            else if (b == 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            
        }
        static void SNT()
        {
            int n;
            do
            {
                Console.Write("Nhap n= ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);

            int GT = 1;
         
            for (int i = 1; i <= n; i++)
            {
                GT *= i;
            }
            Console.WriteLine($"{n}! = {GT}");
        }
        static void Main(string[] args)
        {
            GPTB1();
            SNT();

            Console.ReadKey();
            
        }
    }
}

