using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4___interface.Models.Shape
{
    public class Square : Circle
    {
        private float a;

        public float b
        {
            get
            {
                return a;
            }
        }

        public Square() { }
        public void Nhap()
        {
            Console.Write("Nhap canh a = ");
            a = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{a} x {a}");
        }
        public float getArea()
        {
            return a * a;
        }
    }
}
