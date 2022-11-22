using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo4___interface.Models.Shape
{
    //public abstract class Shape
    //{
    //    public abstract void Nhap();
    //    public abstract void Xuat();

    //    public abstract float getArea();

    //}

    //Không cần override ở lớp dẫn xuất
    public interface Shape
    {
        void Nhap();
        void Xuat();
        float getArea();
    }
}
