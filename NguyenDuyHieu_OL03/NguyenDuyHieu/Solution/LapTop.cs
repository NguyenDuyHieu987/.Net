using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class LapTop : SanPham 
    {
        private string CPU;
        private float RAM;
        private string GPU;
        private string Loaimanhinh;
        
        public float Ram
        {
            get
            {
                return RAM;
            }
        }

        public LapTop() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("CPU: ");
            CPU = Console.ReadLine();

            Console.Write("RAM: ");
            RAM = float.Parse(Console.ReadLine());

            Console.Write("GPU: ");
            GPU = Console.ReadLine();

            Console.Write("Loai man hinh: ");
            Loaimanhinh = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM} GB");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"Loai man hinh: {Loaimanhinh}");
        }




    }

  
}
