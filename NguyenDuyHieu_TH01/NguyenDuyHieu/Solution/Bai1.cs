using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class Bai1
    {
        public void Triangle()
        {
            int n;
            Console.Write("Nhap chieu cao: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ma tran vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
