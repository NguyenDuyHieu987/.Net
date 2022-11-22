using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{


    public class KhachHang
    {
        private string HoTen;
        private string Diachi;
        private int SoNgayO;
        private float TongTien;
        private string LoaiPhong;
        private string TienNghi;
        private string DichVu;

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
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            Diachi = Console.ReadLine();

            Console.Write("Nhap so ngay o: ");
            SoNgayO = int.Parse(Console.ReadLine());

            Console.Write("Chon loai phong(1: Phong don, 2: Phong doi, 3: Phong ba): ");
            int choose1;
            do
            {
                choose1 = int.Parse(Console.ReadLine());
                switch (choose1)
                { 
                    case 1:
                        TongTien = 300000 * SoNgayO;
                        LoaiPhong = "Phong don";
                        break;
                    case 2:
                        TongTien = 350000 * SoNgayO;
                        LoaiPhong = "Phong doi";
                        break;
                    case 3:
                        TongTien = 400000 * SoNgayO;
                        LoaiPhong = "Phong ba";
                        break;
                    default:
                        Console.Write("Nhap sai! Vui long nhap tu 1->3: ");
                        break;
                }
            }
            while (choose1 > 3 || choose1 < 1);

            bool check = true;
            while(check)
            {
                Console.Write("Moi ban chon(1: Tien nghi, 2: Dich vu, 0: Khong chon): ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        check = false;
                        break;

                    case 1:
                        Console.Write("Chon cac tien nghi(1: Tivi, 2: Internet, 3: May nuoc nong): ");
                        int choose2;
                        do
                        {
                            choose2 = int.Parse(Console.ReadLine());
                            switch (choose2)
                            {
                                case 1:
                                    TongTien += 10000;
                                    TienNghi += "Tivi, ";
                                    break;
                                case 2:
                                    TongTien += 10000;
                                    TienNghi += "Internet, ";
                                    break;
                                case 3:
                                    TongTien += 10000;
                                    TienNghi += "May nuoc nong, ";
                                    break;
                                default:
                                    Console.Write("Nhap sai! Vui long nhap tu 1->3: ");
                                    break;
                            }
                        }
                        while (choose2 > 3 || choose2 < 1);                
                        break;

                    case 2:
                        Console.Write("Chon dich vu(1: Karaoke, 2: An sang): ");
                        int choose3;
                        do
                        {
                            choose3 = int.Parse(Console.ReadLine());
                            switch (choose3)
                            {
                                case 1:
                                    TongTien += 15000 * SoNgayO;
                                    DichVu += "Karaoke, ";
                                    break;
                                case 2:
                                    TongTien += 15000 * SoNgayO;
                                    DichVu += "An sang, ";
                                    break;
                                default:
                                    Console.Write("Nhap sai! Vui long nhap tu 1->2: ");
                                    break;
                            }
                                 
                        }
                        while (choose3 > 2 || choose3 < 1) ;
                        break;
                }
               
            }     

        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Dia chi: {Diachi}");
            Console.WriteLine($"So Ngay o: {SoNgayO}");
            Console.WriteLine($"Loai phong: {LoaiPhong}");
            Console.WriteLine($"Tien nghi: {TienNghi}");
            Console.WriteLine($"Dich vu: {DichVu}");
            Console.WriteLine($"Thanh tien {TongTien}");


        }

  

    }
}
