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
        static void NhapDanhSachHanhKhach(List<HanhKhach> HK, int n)
        {
            for (int i = 0; i < n; i++)
            {
                HanhKhach obj1 = new HanhKhach();
                Console.WriteLine($"Nhap hanh khach thu {i + 1}");
                obj1.Nhap();
                HK.Add(obj1);
                Console.WriteLine();
            }
        }
        static void XuatDanhSachHanhKhach(List<HanhKhach> HK)
        {
            for (int i = 0; i < HK.Count; i++)
            {
                Console.WriteLine($"Hanh khach thu {i + 1}");
                HK[i].Xuat();
                Console.WriteLine($"So tien phai tra: {HK[i].TongTien()}");
                Console.WriteLine();
            }
        }

        static void SapXep_TongTien_TangDan(List<HanhKhach> HK)
        {
            for (int i = 0; i < HK.Count - 1; i++)
            {
                for (int j = i+1; j < HK.Count; j++)
                {
                    if(HK[i].TongTien() > HK[j].TongTien())
                    { 
                        HanhKhach temp = new HanhKhach();
                        temp = HK[i];
                        HK[i] = HK[j];
                        HK[j] = temp;
                    }
                   
                }

            }
        }

        static void NhapCacSanPham(List<LapTop> LT, List<Tivi> TV, List<Dieuhoa> DH, int m)
        {
            Console.WriteLine("====Nhap san pham laptop====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Nhap san pham thu {i + 1}");
                LapTop obj1 = new LapTop();
                obj1.Nhap();
                LT.Add(obj1);
                Console.WriteLine();
            }


            Console.WriteLine("====Nhap san pham Tivi====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Nhap san pham thu {i + 1}");
                Tivi obj2 = new Tivi();
                obj2.Nhap();
                TV.Add(obj2);
                Console.WriteLine();
            }


            Console.WriteLine("====Nhap san pham dieu hoa====");
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Nhap san pham thu {i + 1}");
                Dieuhoa obj3 = new Dieuhoa();
                obj3.Nhap();
                DH.Add(obj3);
                Console.WriteLine();
            }

        }

        static void XuatCacSanPham(List<LapTop> LT, List<Tivi> TV, List<Dieuhoa> DH)
        {
            Console.WriteLine("\n====LapTop ====");
            for (int i = 0; i < LT.Count; i++)
            {
                Console.WriteLine($"\nsan pham thu {i + 1}");
                LT[i].Xuat();
                Console.WriteLine($"Loi nhuan: {LT[i].LoiNhuan()}");
            }

            Console.WriteLine("\n====Tivi====");
            for (int i = 0; i < TV.Count; i++)
            {
                Console.WriteLine($"\nsan pham thu {i + 1}");
                TV[i].Xuat();
                Console.WriteLine($"Loi nhuan: {TV[i].LoiNhuan()}");
            }

            Console.WriteLine("\n====Dieu hoa====");
            for (int i = 0; i < DH.Count; i++)
            {
                Console.WriteLine($"\nsan pham thu {i + 1}");
                DH[i].Xuat();
                Console.WriteLine($"Loi nhuan: {DH[i].LoiNhuan()}");
            }
        }

        static void SapXepTangDan_LoiNhuan(List<LapTop> LT, List<Tivi> TV, List<Dieuhoa> DH)
        {
            for (int i = 0; i < LT.Count - 1; i++)
            {
                for (int j = i + 1; j < LT.Count; j++)
                {
                    if (LT[i].LoiNhuan() > LT[j].LoiNhuan())
                    {
                        LapTop temp = new LapTop();
                        temp = LT[i];
                        LT[i] = LT[j];
                        LT[j] = temp;
                    }
                }

            }


            for (int i = 0; i < TV.Count - 1; i++)
            {
                for (int j = i + 1; j < TV.Count; j++)
                {
                    if (TV[i].LoiNhuan() > TV[j].LoiNhuan())
                    {
                        Tivi temp = new Tivi();
                        temp = TV[i];
                        TV[i] = TV[j];
                        TV[j] = temp;
                    }
                }

            }

            for (int i = 0; i < DH.Count - 1; i++)
            {
                for (int j = i + 1; j < DH.Count; j++)
                {
                    if (DH[i].LoiNhuan() > DH[j].LoiNhuan())
                    {
                        Dieuhoa temp = new Dieuhoa();
                        temp = DH[i];
                        DH[i] = DH[j];
                        DH[j] = temp;
                    }
                }

            }
        }

        static void RamLapTop_Max(List<LapTop> LT)
        {
            Solution.LapTop Max = new Solution.LapTop();
            LT[0] = Max;
            for (int i = 0; i < LT.Count; i++)
            {
                if (LT[i].Ram > Max.Ram)
                {
                    Max = LT[i];
                }
            }

            Console.WriteLine("\n====Nhung LapTop co RAM cao nhat la====");
            for (int i = 0; i < LT.Count; i++)
            {
                if (LT[i].Ram == Max.Ram)
                {
                    LT[i].Xuat();
                    Console.WriteLine($"Loi nhuan: {LT[i].LoiNhuan()}");
                }
            }
        }


        static void Tivi_Android(List<Tivi> TV)
        {
            int dem = 0;
            Console.WriteLine("\n====Nhung Tivi co he dieu hanh ANDROID nhat la====");
            for (int i = 0; i < TV.Count; i++)
            {
                if (TV[i].HDH == "ANDROID")
                {
                    dem++;
                    TV[i].Xuat();
                    Console.WriteLine($"Loi nhuan: {TV[i].LoiNhuan()}");
                }
            }
            if(dem == 0)
            {
                Console.WriteLine("\n====Khong co nao Tivi co he dieu hanh ANDROID====");
            }
        }


        static float TongSanPhan_DieuHoa(List<Dieuhoa> DH)
        {
            float sum = 0;
            for (int i = 0; i < DH.Count; i++)
            {
                sum = sum + DH[i].gianhap;
            }
            return sum;
        }

        static void NhapKhachHang(List<KhachHang> KH, int n)
        {
            for (int i = 0; i < n; i++)
            {
                KhachHang obj1 = new KhachHang();
                Console.WriteLine($"Nhap khach hang thu {i + 1}");
                obj1.Nhap();
                KH.Add(obj1);
                Console.WriteLine();
            }
        }

        static void XuatKhachHang(List<KhachHang> KH)
        {   
            for (int i = 0; i < KH.Count; i++)
            {
                Console.WriteLine($"Khach hang thu {i + 1}");
                KH[i].Xuat();
                Console.WriteLine();
            }        
        }

        static float TongTienThuDuoc(List<KhachHang> KH)
        {
            float sum = 0;
            for (int i = 0; i < KH.Count; i++)
            {
                sum += KH[i].tongtien;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            //Bài 1 
            //int a, b;
            //Console.Write("Nhap a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: ");
            //b = int.Parse(Console.ReadLine());
            //Bai1 obj = new Bai1();
            //Console.WriteLine($"UCLN cua {a} va {b} la: {obj.UCLN(a, b)}");
            //Console.WriteLine($"BCLN cua {a} va {b} la: {obj.BCNN(a, b)}");


            //Bài 2;
            //int n;
            //Console.Write("Nhap so hanh khach: ");
            //n = int.Parse(Console.ReadLine());

            //List<HanhKhach> HK = new List<HanhKhach>();
            //NhapDanhSachHanhKhach(HK, n);
            //XuatDanhSachHanhKhach(HK);
            //SapXep_TongTien_TangDan(HK);
            //Console.WriteLine("==== Danh sanh khach hang sau khi sap xep la ====");
            //XuatDanhSachHanhKhach(HK);



            //Bài 3
            List<KhachHang> KH = new List<KhachHang>();
            int n;
            Console.Write("Nhap so khach hang: ");
            n = int.Parse(Console.ReadLine());

            NhapKhachHang(KH, n);
            Console.WriteLine("===== Danh sach khach hang sau khi nhap la =====");
            XuatKhachHang(KH);

            Console.WriteLine($"Tong tien thu duoc trong ngay la: {TongTienThuDuoc(KH)}");

            





            //Bài 5
            //int m;

            //Console.Write("Nhap so san pham: ");
            //m = Convert.ToInt32(Console.ReadLine());

            //List<LapTop> LT;
            //List<Tivi> TV;
            //List<Dieuhoa> DH;

            //LT = new List<LapTop>();
            //TV = new List<Tivi>();
            //DH = new List<Dieuhoa>();

            //NhapCacSanPham(LT, TV, DH, m);
            //XuatCacSanPham(LT, TV, DH);


            //SapXepTangDan_LoiNhuan(LT, TV, DH);
            //Console.WriteLine("\n=====Cac san phan sau khi sap xep tang dan theo loi nhuan la=====");
            //XuatCacSanPham(LT, TV, DH);


            //RamLapTop_Max(LT);

            //Console.WriteLine($"\nTong gia nhap cua san pham dieu hoa la: {TongSanPhan_DieuHoa(DH)}");


            Console.ReadKey();
        }
    }
}
