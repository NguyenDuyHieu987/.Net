using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using demo4___interface.Models.Shape;

namespace demo4___interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.Shape.Shape obj = new Models.Shape.Circle();
            obj.Nhap();
            obj.Xuat();

            Console.WriteLine($"Area = {obj.getArea()}");

            obj = new Models.Shape.Square();
            obj.Nhap();
            obj.Xuat();

            Console.WriteLine($"Area = {obj.getArea()}");


            Console.ReadKey();
        }
    }
}
