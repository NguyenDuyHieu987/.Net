using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class Bai2
    {
        public void Inthanhchu()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 0:
                        Console.WriteLine("So khong");
                        break;
                    case 1:
                        Console.WriteLine("So mot");
                        break;
                    case 2:
                        Console.WriteLine("So hai");
                        break;
                    case 3:
                        Console.WriteLine("So ba");
                        break;
                    case 4:
                        Console.WriteLine("So bon");
                        break;
                    case 5:
                        Console.WriteLine("So nam");
                        break;
                    case 6:
                        Console.WriteLine("So sau");
                        break;
                    case 7:
                        Console.WriteLine("So bay");
                        break;
                    case 8:
                        Console.WriteLine("So tam");
                        break;
                    case 9:
                        Console.WriteLine("So chin");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap so tu 0->9");
                        break;

                }
            }
            while (n < 0 || n > 9);
            

        }
            
            
    }
}
