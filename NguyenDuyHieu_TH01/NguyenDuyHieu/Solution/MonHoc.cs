using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    class MonHoc
    {
        private int MaMon;
        private string TenMon;
        private int SoTinChi;

        public int STC
        {
            get
            {
                return SoTinChi;
            }
        }
        

        public MonHoc() { }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma mon: ");
            MaMon = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten mon: ");
            TenMon = Console.ReadLine();

            Console.Write("Nhap so tin chi: ");
            SoTinChi = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ma mon: {MaMon}");
            Console.WriteLine($"Ten mon: {TenMon}");
            Console.WriteLine($"So tin chi: {SoTinChi}");
        }
    }
}
