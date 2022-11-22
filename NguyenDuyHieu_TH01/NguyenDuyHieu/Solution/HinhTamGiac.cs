using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    class HinhTamGiac
    {
        private int ma;
        private int mb;
        private int mc;
        
       
        public HinhTamGiac() { }
        public HinhTamGiac(int a, int b, int c)
        {
          
            if (a < 0)
            {
                Console.WriteLine($"{a} la so am duoc gan bang 0");
                this.ma = 0;
            }
                    
            if (b < 0)
            {
                Console.WriteLine($"{b} la so am duoc gan bang 0");
                this.mb = 0;
            }
                    
            if (c < 0)
            {
                Console.WriteLine($"{c} la so am duoc gan bang 0");
                this.mc = 0;
            }
            if (IsTamGiac(a, b, c))
            {
                this.ma = a;
                this.mb = b;
                this.mc = c;

            }
            else
            {
                Console.WriteLine("khong phai hinh tam giac");
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }

        }
        public void Nhap()
        {
            Console.Write("Nhap a : ");
            ma = int.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            mb = int.Parse(Console.ReadLine());
            Console.Write("Nhap c : ");
            mc = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Canh a : {ma}");
            Console.WriteLine($"Canh b : {mb}");
            Console.WriteLine($"Canh c : {mc}");
        }

        public int getCanhA()
        {
            return ma;
        }

        public void setCanhA(int a)
        {
            if((a != 0) || (a < mb + mc && mb < a + mc && mc < a + mb))
            {
                ma = a;
            }
           
        }

        public int getCanhB()
        {
            return mb;
        }

        public void setCanhB(int b)
        {
            if ((b != 0) || (ma < mb + mc && b < ma + mc && mc < ma + b))
            {
                mb = b;
            }
        }
        public int getCanhC()
        {
            return mc;
        }

        public void setCanhC(int c)
        {
            if ((c != 0) || (ma < mb + c && mb < ma + c && c < ma + mb))
            {
                mc = c;
            }
        }

        public Boolean IsTamGiac()
        {
            if(ma > 0 || mb > 0 || mc > 0)
            {
                if (ma < mb + mc && mb < ma + mc && mc < ma + mb)
                    return true;
                else
                    return false;
            }   
            else
                return false;
        }

        public Boolean IsTamGiac(int a, int b, int c)
        {
            
            if (a < b + c && b < a + c && c < a + b)
                return true;
            else
                return false;
        }

        public int getChuVi()
        {
            return ma + mb + mc;
        }
        public double getDienTich()
        {
            double DT = Math.Sqrt(getChuVi() * (getChuVi() - ma) * (getChuVi() - mb) * (getChuVi() - mc));
            return (DT);
        }
    }
}
