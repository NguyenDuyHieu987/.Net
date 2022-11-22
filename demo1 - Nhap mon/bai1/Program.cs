using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string s = Console.ReadLine();

            Console.WriteLine("s = " + s);

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {(a + b)}");
            //Console.WriteLine(a +  " + " + b + " = " + (a + b));
            //chuyen so ve chuoi
            //a.ToString();
            
            
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    break;
                }
                Console.WriteLine(i);
            }
           
            Console.ReadKey();
        }
    }
}
