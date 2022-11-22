using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class Tivi : SanPham
    {
        private float Kichthuoc;
        private string HeDieuHanh;
        private string Chucnang;

        public string HDH
        {
            get
            {
                return HeDieuHanh;
            }
        }

        public Tivi() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("kich thuoc: ");
            Kichthuoc = float.Parse(Console.ReadLine());

            Console.Write("He dieu hanh: ");
            HeDieuHanh = Console.ReadLine();

            Console.Write("Chuc nang: ");
            Chucnang = Console.ReadLine();

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"kich thuoc: {Kichthuoc} INCH");
            Console.WriteLine($"He dieu hanh: {HeDieuHanh}");
            Console.WriteLine($"Chuc nang: {Chucnang}");
        }
    }
}
