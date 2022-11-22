using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    class VeMayBay
    {
        private string TenChuyen;
        private string NgayBay;
        private float GiaVe;

        public float giave
        {
            get
            {
                return GiaVe;
            }
        }

        public VeMayBay() { }
        public void Nhap()
        {
            Console.Write("Nhap ten chuyen: ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhap ngay bay: ");
            NgayBay = Console.ReadLine();
            Console.Write("Nhap gia ve: ");
            GiaVe = float.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"Ten chuyen: {TenChuyen}");
            Console.WriteLine($"Ngay bay: {NgayBay}");
            Console.WriteLine($"Gia ve: {GiaVe}");
        }
    }
}
