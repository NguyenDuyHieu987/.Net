using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3___out__ref__param
{
    class Program
    {
        static void Nhap(ref string name, ref float mark, ref int age)
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap diem: ");
            mark = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nhap tuoi: ");
            age = Convert.ToInt32(Console.ReadLine());

        }

        static void Xuat(string name, float mark, int age)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Name: {mark}");
            Console.WriteLine($"Name: {age}");
        }
        static double Avg(params double[] a)
        {
            double sum = 0;
            foreach (double item in a)
            {
                sum += item;
            }
            return (a.Length == 0) ? 0 : (sum / a.Length);
        }

        
        static void Main(string[] args)
        {
            string name = default;
            float mark = default;
            int age = default;

            //Nhap(ref name, ref mark, ref age);
            //Xuat(name, mark, age);

            double[] a = { 1, 2, 3, 4, 5 };
            float b = 2.3f;


            double AvG = Avg(3, 4, 5, b);
            Console.WriteLine($"AvG = {AvG}");

            Console.ReadKey();
        }

        
    }
}
