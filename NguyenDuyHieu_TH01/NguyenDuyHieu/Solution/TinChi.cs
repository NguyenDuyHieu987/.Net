using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    class TinChi : MonHoc
    {
        private float DiemTP;
        private float DiemThi;

        public TinChi() { }

        public override void Nhap()
        {
            base.Nhap();

            Console.Write("Nhap diem thanh phan: ");
            DiemTP = float.Parse(Console.ReadLine());

            Console.Write("Nhap diem thi: ");
            DiemThi = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();

            Console.WriteLine($"Diem thanh phan: {DiemTP}");
            Console.WriteLine($"Diem thi: {DiemThi}");
        }
        
        public float TinhDiemTK()
        {
            return (float)((0.3 * DiemTP) + (0.7 * DiemThi));
        }
    }
}
