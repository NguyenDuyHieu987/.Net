using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class SanPham
    {
        private int Ma;
        private float GiaNhap;
        private float GiaBan;
        private int SoLuong;
        private string HangSX;

        public float gianhap
        {
            get
            {
                return GiaNhap;
            }
        }

        public SanPham() { }

        public virtual void Nhap()
        {
            Console.Write("Nhap Ma: ");
            Ma = int.Parse(Console.ReadLine());

            Console.Write("Nhap gia nhap: ");
            GiaNhap = float.Parse(Console.ReadLine());

            Console.Write("Nhap gia ban: ");
            GiaBan = float.Parse(Console.ReadLine());

            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());

            Console.Write("Nhap hang san xuat: ");
            HangSX = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma: {Ma}");
            Console.WriteLine($"gia nhap: {GiaNhap}");
            Console.WriteLine($"gia ban: {GiaBan}");
            Console.WriteLine($"so luong: {SoLuong}");
            Console.WriteLine($"hang san xuat: {HangSX}");
        }

        public float LoiNhuan()
        {
            float LoiNhuan;
            LoiNhuan = SoLuong * GiaBan - SoLuong * GiaNhap;
            return LoiNhuan;
        }
    }
}
