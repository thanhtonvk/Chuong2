using System;

namespace Bai8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hinh tam giac: ");
            TamGiac tamGiac = new TamGiac();
            tamGiac.Nhap();
            Console.WriteLine("chu vi tam giac la: " + tamGiac.ChuVi());
            Console.WriteLine("dien tich tam giac la: " + tamGiac.DienTich());
            Console.WriteLine("Hinh chu nhat: ");
            HinhChuNhat hinhChuNhat = new HinhChuNhat();
            hinhChuNhat.Nhap();
            Console.WriteLine("Chu vi hinh chu nhat: " + hinhChuNhat.ChuVi());
            Console.WriteLine("Dien tich hinh chu nhat: " + hinhChuNhat.DienTich());
        }
    }
}