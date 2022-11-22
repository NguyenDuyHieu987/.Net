using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu
{
    class Program
    {
        static void NhapCacSanPham(Solution.LapTop[] LT, Solution.Tivi[] TV, Solution.Dieuhoa[] DH, int m)
        {
            Console.WriteLine("====Nhap san pham laptop====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Nhap san pham thu {i + 1}");
                LT[i] = new Solution.LapTop();
                LT[i].Nhap();
                Console.WriteLine();
            }


            Console.WriteLine("====Nhap san pham Tivi====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Nhap san pham thu {i + 1}");
                TV[i] = new Solution.Tivi();
                TV[i].Nhap();
                Console.WriteLine();
            }


            Console.WriteLine("====Nhap san pham dieu hoa====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Nhap san pham thu {i + 1}");
                DH[i] = new Solution.Dieuhoa();
                DH[i].Nhap();
                Console.WriteLine();
            }

        }

        static void XuatCacSanPham(Solution.SanPham[] LT, Solution.SanPham[] TV, Solution.SanPham[] DH, int m)
        {
            Console.WriteLine("\n====LapTop ====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"\nsan pham thu {i + 1}");
                LT[i].Xuat();
                Console.WriteLine($"Loi nhuan: {LT[i].LoiNhuan()}");
            }

            Console.WriteLine("\n====Tivi====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"\nsan pham thu {i + 1}");
                TV[i].Xuat();
                Console.WriteLine($"Loi nhuan: {TV[i].LoiNhuan()}");
            }

            Console.WriteLine("\n====Dieu hoa====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"\nsan pham thu {i + 1}");
                DH[i].Xuat();
                Console.WriteLine($"Loi nhuan: {DH[i].LoiNhuan()}");
            }
        }

        static void SapXepTangDan_LoiNhuan(Solution.SanPham[] LT, Solution.SanPham[] TV, Solution.SanPham[] DH, int m)
        {
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (LT[i].LoiNhuan() > LT[j].LoiNhuan())
                    {
                        Solution.SanPham temp = new Solution.LapTop();
                        temp = LT[i];
                        LT[i] = LT[j];
                        LT[j] = temp;
                    }
                }

            }


            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (TV[i].LoiNhuan() > TV[j].LoiNhuan())
                    {
                        Solution.SanPham temp = new Solution.Tivi();
                        temp = TV[i];
                        TV[i] = TV[j];
                        TV[j] = temp;
                    }
                }

            }

            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    if (DH[i].LoiNhuan() > DH[j].LoiNhuan())
                    {
                        Solution.SanPham temp = new Solution.Dieuhoa();
                        temp = DH[i];
                        DH[i] = DH[j];
                        DH[j] = temp;
                    }
                }

            }
        }

        static void RamLapTop_Max(Solution.LapTop[] LT, int m)
        {
            Solution.LapTop Max = new Solution.LapTop();
            LT[0] = Max;
            for (int i = 0; i < m; i++)
            {
                if(LT[i].Ram > Max.Ram)
                {
                    Max = LT[i];
                }
            }

            Console.WriteLine("\n====Nhung LapTop co RAM cao nhat la====");
            for (int i = 0; i < m; i++)
            {
                if (LT[i].Ram == Max.Ram)
                {
                    LT[i].Xuat();
                    Console.WriteLine($"Loi nhuan: {LT[i].LoiNhuan()}");
                }
            }
        }


        static void Tivi_Android(Solution.Tivi[] TV, int m)
        {
            Console.WriteLine("\n====Nhung Tivi co he dieu hanh ANDROID nhat la====");
            for (int i = 0; i < m; i++)
            {
                if (TV[i].HDH == "ANDROID")
                {
                    TV[i].Xuat();
                    Console.WriteLine($"Loi nhuan: {TV[i].LoiNhuan()}");
                }
            }
        }


        static float TongSanPhan_DieuHoa(Solution.Dieuhoa[] DH, int m)
        {
            float sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum = sum + DH[i].gianhap;
            }
            return sum;
        }

        static void NhapKhachHang(Solution.KhachHang[] KH, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap khach hang thu {i + 1}");
                KH[i] = new Solution.KhachHang();
                KH[i].Nhap();
                Console.WriteLine();
            }
        }

        static void XuatKhachHang(Solution.KhachHang[] KH, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Khach hang thu {i + 1}");
                KH[i].Xuat();
                Console.WriteLine();
            }
        }

        static float TongTienThuDuoc(Solution.KhachHang[] KH, int n)
        {
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += KH[i].tongtien;
            }
            return sum;
        }

        static void Dichvu_TheMostChoice(Solution.KhachHang[] KH, int n)
        {
            int sum_Caovoi = 0;
            int sum_Taytrang = 0;
            int sum_Nhorang = 0;
            int sum_Tramrang = 0;
            for (int i = 0; i < n; i++)
            {
                sum_Caovoi += KH[i].dem_CaoVoi;
                sum_Taytrang += KH[i].dem_TayTrang;
                sum_Nhorang += KH[i].dem_NhoRang;
                sum_Tramrang += KH[i].dem_TramRang;
            }

            int Max = sum_Caovoi;
            Max = Math.Max(Max, sum_Taytrang);
            Max = Math.Max(Max, sum_Nhorang);
            Max = Math.Max(Max, sum_Tramrang);

            if(sum_Caovoi == Max)
            {
                Console.WriteLine("Dich vu su dung nhieu nhat trpng ngay la: Cao voi");
                Console.WriteLine("Don gia: 100000");
                Console.WriteLine($"Tong so lan phuc vu: {sum_Caovoi}");
            }
            if (sum_Taytrang == Max)
            {
                Console.WriteLine("Dich vu su dung nhieu nhat trpng ngay la: Tay trang");
                Console.WriteLine("Don gia: 1500000");
                Console.WriteLine($"Tong so lan phuc vu: {sum_Taytrang}");
            }
            if (sum_Nhorang == Max)
            {
                Console.WriteLine("Dich vu su dung nhieu nhat trpng ngay la: Nho rang");
                Console.WriteLine("Don gia: 150000");
                Console.WriteLine($"Tong so lan phuc vu: {sum_Nhorang}");
            }
            if (sum_Tramrang == Max)
            {
                Console.WriteLine("Dich vu su dung nhieu nhat trpng ngay la: Tram rang");
                Console.WriteLine("Don gia: 200000");
                Console.WriteLine($"Tong so lan phuc vu: {sum_Tramrang}");
            }

        }

        static void Main(string[] args)
        {
            //Bai 1
            int n;
            Solution.KhachHang[] KH;

            Console.Write("Nhap so khach hang: ");
            n = Convert.ToInt32(Console.ReadLine());

            KH = new Solution.KhachHang[n];


            Console.WriteLine("====Nhap mang khach hang====");
            NhapKhachHang(KH, n);
            Console.WriteLine("====Mang khach hang sau khi nhap====");
            XuatKhachHang(KH, n);
            Console.WriteLine($"Tong tien thu duoc trong ngay la: {TongTienThuDuoc(KH,n)}");

            Dichvu_TheMostChoice(KH,n);



            //Bai 2 
            //int m;

            //Console.Write("Nhap so san pham: ");
            //m = Convert.ToInt32(Console.ReadLine());

            //Solution.LapTop[] LT;
            //Solution.Tivi[] TV;
            //Solution.Dieuhoa[] DH;

            //LT = new Solution.LapTop[m];
            //TV = new Solution.Tivi[m];
            //DH = new Solution.Dieuhoa[m];

            //NhapCacSanPham(LT,TV,DH,m);
            //XuatCacSanPham(LT,TV,DH,m);


            //SapXepTangDan_LoiNhuan(LT,TV,DH,m);
            //Console.WriteLine("\n=====Cac san phan sau khi sap xep tang dan theo loi nhuan la=====");
            //XuatCacSanPham(LT, TV, DH, m);

            //RamLapTop_Max(LT, m);

            //Console.WriteLine($"\nTong gia nhap cua san pham dieu hoa la: {TongSanPhan_DieuHoa(DH,m)}");



            Console.ReadKey();
        }
    }
}
