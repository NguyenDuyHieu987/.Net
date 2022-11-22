using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 1;
                Console.Write("Nhap a = ");
                a = int.Parse(Console.ReadLine());
                if(a % 2 == 0)
                {
                    throw new Exception("A khong duoc la so chan!");
                }
                Console.Write("Nhap a = ");
                b = int.Parse(Console.ReadLine());
                int x = -b / a;
                Console.WriteLine($"Phuong trinh co nghiem x = {x}");

            }
            catch(Exception ex)
            {
                //throw ex;
                Console.WriteLine($"Error: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Giai phuong trinh thanh cong");
                Console.ReadKey();
            }
            
            

        }
    }
}
