using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    enum GT { Nam, Nu }
    class Nguoi
    {
        private string HoTen;
        private GT GioiTinh;
        private int Tuoi;

        public Nguoi() { }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap gioi tinh(1: Nam, 0: Nu): ");
            int choose = int.Parse(Console.ReadLine());
            if(choose == 1)
            {
                GioiTinh = GT.Nam;
            }
            if (choose == 0)
            {
                GioiTinh = GT.Nu;
            }

            Console.Write("Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Gioi Tinh: {GioiTinh}");
            Console.WriteLine($"Tuoi: {Tuoi}");
        }
    }
}
