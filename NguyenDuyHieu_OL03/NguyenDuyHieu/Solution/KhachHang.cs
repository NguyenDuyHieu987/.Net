using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class KhachHang
    {
        private string TenKH;
        private string CaoVoi = "Khong";
        private string TayTrang = "Khong";
        private int NhoRang = 0;
        private int TramRang = 0;
        private float TongTien;

        public int dem_CaoVoi = 0;
        public int dem_TayTrang = 0;
        public int dem_NhoRang = 0;
        public int dem_TramRang = 0;


        public float tongtien
        {
            get
            {
                return TongTien;
            }
        }

        public KhachHang() { }
        public void Nhap()
        {
            Console.Write("Nhap ten khach hang: ");
            TenKH = Console.ReadLine();
                   
            bool check = true;
          
            while(check)
            {
                Console.WriteLine("======== Chon dich vu =========");
                Console.WriteLine("1: Cao voi");
                Console.WriteLine("2: Tay trang");
                Console.WriteLine("3: Nho rang");
                Console.WriteLine("4: Tram rang");
                Console.WriteLine("0: Khong chon nua");
                Console.Write("Moi ban chon: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                { 
                    case 0:
                        check = false;
                        break;
                    case 1:     
                        if(dem_CaoVoi == 0)
                        {
                            dem_CaoVoi++;
                            TongTien += 100000;
                            CaoVoi = "Co";
                        }
                        else
                            Console.WriteLine("Loi! Dich vu chi duoc chon 1 lan");
                        break;

                    case 2:    
                        if(dem_TayTrang == 0)
                        {
                            dem_TayTrang++;
                            TongTien += 1500000;
                            TayTrang = "Co";
                        }
                        else                       
                            Console.WriteLine("Loi! Dich vu chi duoc chon 1 lan");  
                        break;

                    case 3:                         
                        if(dem_NhoRang == 0)
                        { 
                            dem_NhoRang++;
                            Console.WriteLine("Nhap so rang muon nho: ");
                            NhoRang = int.Parse(Console.ReadLine());
                            TongTien += 150000 * NhoRang;
                        }              
                        else
                            Console.WriteLine("Loi! Dich vu chi duoc chon 1 lan");
                        break;

                    case 4:     
                        if(dem_TayTrang == 0)
                        {
                            dem_TramRang++;
                            Console.Write("Nhap so rang muon tram: ");
                            TramRang = int.Parse(Console.ReadLine());
                            TongTien += 200000 * TramRang;   
                        }
                        else
                            Console.WriteLine("Loi! Dich vu chi duoc chon 1 lan");
                        break;

                }

            }
            
                    
        }

        public void Xuat()
        {
            Console.WriteLine($"Ten khach hang: {TenKH}");
            Console.WriteLine($"Cao voi: {CaoVoi}");
            Console.WriteLine($"Tay trang: {TayTrang}");
            Console.WriteLine($"Nho rang: {NhoRang} cai rang");
            Console.WriteLine($"Tram rang: {TramRang} cai rang");
            Console.WriteLine($"Tong tien: {TongTien}");

        }


    }
}
