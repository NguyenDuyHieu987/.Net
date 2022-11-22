using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    
    class HanhKhach : Nguoi
    {
        private List<VeMayBay> VMB = new List<VeMayBay>();
        
        public HanhKhach() { }

        public override void Nhap()
        {
            base.Nhap();
            
            int n;
            Console.Write("Nhap so ve da mua: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                VeMayBay obj = new VeMayBay();
                Console.WriteLine("Nhap ve thu " + (i+1) + ": ");
                obj.Nhap();
                VMB.Add(obj);
            }
        }

        public override void Xuat()
        {
            base.Xuat();

            for(int i = 0; i<VMB.Count; i++)
            {
                Console.WriteLine("Ve thu " + (i + 1) + ": ");
                VMB[i].Xuat();
            }
        }

        public float TongTien()
        {
            float sum = 0;
            for (int i = 0; i < VMB.Count; i++)
            {
                sum += VMB[i].giave;
            }
            return sum;
        }
    }
}
