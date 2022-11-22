using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo3___class
{
    class Program
    {
        static void Main(string[] args)
        {
            //class
            //Models.ConNguoi obj = new Models.ConNguoi();
            //obj.Xuat();

            //Models.ConNguoi obj = new Models.ConNguoi("112233", "Nguyen Van A", "Ha Noi", 2002);
            //obj.Xuat();

            //Models.ConNguoi cn = new Models.ConNguoi();
            //cn.Nhap();
            //cn.Xuat();

            //Inheritance: kế thừa 
            //Models.SinhVien obj = new Models.SinhVien("123", "D15CNPM2", (float)9.0, "112233", "Nguyen Van A", "Ha Noi", 2002);
            //obj.Xuat();

            //Models.SinhVien sv = new Models.SinhVien();
            //sv.Nhap();
            //sv.Xuat();

            //Polymorphism: Đa hình
            //Models.ConNguoi obj = new Models.SinhVien();
            //obj.Nhap();
            //obj.Xuat();

            //obj = new Models.GiangVien();
            //obj.Nhap();
            //obj.Xuat();

            //Overriding: ghi đè
            //Models.ConNguoi sv = new Models.SinhVien();
            //Models.ConNguoi gv = new Models.GiangVien();
            //sv.Output();
            //gv.Output();


            //Models.SinhVien obj = new Models.SinhVien();
            //obj.Nhap();
            //obj.Xuat();

            //Console.Write($"Ma sinh vien vua nhap la: {obj.maSV}");
            //obj.dtb = 10;
            //obj.Xuat();


            //Tạo 1 danh sách Sinh Viên để quản lý
            List<Models.SinhVien> lst = new List<Models.SinhVien>();
            for(int i = 0; i<3; i++)
            {
                //Tạo 1 sinh viên 
                Models.SinhVien obj = new Models.SinhVien();
                obj.Nhap();
                //Thêm sinh viên này vào danh sách
                lst.Add(obj);
            }
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i].Xuat();
            }

            Console.ReadKey();

        }
    }
}
