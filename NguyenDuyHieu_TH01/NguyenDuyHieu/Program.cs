using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NguyenDuyHieu.Solution;
namespace NguyenDuyHieu
{
    class Program
    {
        static void NhapDanhSachSinhVien(SinhVien[] SV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                SV[i] = new SinhVien();
                Console.WriteLine($"Nhap sinh vien thu {i+1}: ");
                SV[i].Nhap();
                Console.WriteLine();
            }
            

        }

        static void XuatDanhSachSinhVien(SinhVien[] SV, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Sinh vien thu {i + 1}: ");
                SV[i].Xuat();
                Console.WriteLine($"Diem tong ket toan khoa: {SV[i].TinhTongket()}");
                Console.WriteLine();

            }

        }
        static void XeploaiSV(SinhVien[] SV, int n)
        {
            Console.WriteLine("Cac sinh vien xep loai TB la: ");
            for (int i = 0; i < n; i++)
            {
                if(SV[i].TinhTongket() < 6)
                {
                    SV[i].Xuat();
                }
           
            }

            Console.WriteLine("Cac sinh vien xep loai KHA la: ");
            for (int i = 0; i < n; i++)
            {
                if (SV[i].TinhTongket() >= 6 || SV[i].TinhTongket() < 8)
                {
                    SV[i].Xuat();
                }

            }

            Console.WriteLine("Cac sinh vien xep loai GIOI la: ");
            for (int i = 0; i < n; i++)
            {
                if (SV[i].TinhTongket() >= 8)
                {
                    SV[i].Xuat();
                }

            }

        }

        static void SapXepTangDan(SinhVien[] SV, int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    SinhVien temp = new SinhVien();
                    if(SV[i].TinhTongket() > SV[j].TinhTongket())
                    {
                        temp = SV[i];
                        SV[i] = SV[j];
                        SV[j] = temp;
                    }

                }

            }
        }


        static void Main(string[] args)
        {
            //Bai 1

            //Tamgiac obj = new Tamgiac();
            //obj.Triangle();

            //Bai 2
            //Bai2 obj1 = new Bai2();
            //obj1.Inthanhchu();

            //Bai 3


            //Bai 4
            int n;
            Console.Write("Nhap so sinh vien: ");
            n = int.Parse(Console.ReadLine());

            SinhVien[] SV = new SinhVien[n];
            NhapDanhSachSinhVien(SV, n);
            Console.WriteLine("Danh sach sinh vien sau khi nhap la: ");
            XuatDanhSachSinhVien(SV, n);

            XeploaiSV(SV, n);

            Console.WriteLine("Danh sach sinh vien sau khi sap xep la: ");
            SapXepTangDan(SV, n);

            //Bai 5
            //HinhTamGiac TG = new HinhTamGiac(-3, 4, 5);
            //Console.WriteLine($"Chu vi: {TG.getChuVi()}");
            //Console.WriteLine($"DienTich: {TG.getDienTich()}");

            //HinhTamGiac TG1 = new HinhTamGiac();
            //TG1.Nhap();
            //Console.WriteLine("Tam giac sau khi nhap: ");
            //TG1.Xuat();
            //Console.WriteLine($"Chu vi: {TG.getChuVi()}");
            //Console.WriteLine($"DienTich: {TG.getDienTich()}"); 
            //Console.WriteLine(TG1.IsTamGiac());
            //Console.WriteLine(TG1.IsTamGiac(3,4,5));

            //Console.ReadKey();
        }
    }
}
