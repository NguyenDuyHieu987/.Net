using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    class Dieuhoa : SanPham
    {
        private float CongSuat;
        private string Haichieu;

        public Dieuhoa() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Cong suat: ");
            CongSuat = float.Parse(Console.ReadLine());

            Console.Write("Hai Chieu: ");
            Haichieu = Console.ReadLine();


        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Cong suat: {CongSuat}");
            Console.WriteLine($"Hai Chieu: {Haichieu}");
        }
    }
}
