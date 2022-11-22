using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    class SinhVien
    {
        private int MaSV;
        private string HoTen;
        private int SoLuongtinchi;
        private TinChi[] TC;


        public SinhVien() { }

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho va ten sinh vien: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap so luong tin chi: ");
            SoLuongtinchi = int.Parse(Console.ReadLine());

            TC = new TinChi[SoLuongtinchi];
            for (int i = 0; i < SoLuongtinchi; i++)
            {
                TC[i] = new TinChi();
                TC[i].Nhap();
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"Ma sinh vien: {MaSV}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"So luong tin chi: {SoLuongtinchi}");

            for (int i = 0; i < SoLuongtinchi; i++)
            {
                TC[i].Xuat();
            }
        }

        
        
        public float TinhTongket()
        {
            float SUM = 0;
            float TongSTC = 0;

            for (int i =0; i< SoLuongtinchi; i++)
            {
                SUM += (TC[i].TinhDiemTK()*TC[i].STC);
                TongSTC += TC[i].STC;
            }
            return SUM/TongSTC;
        }
        
    }
}
