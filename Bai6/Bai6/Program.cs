using System;

namespace Bai6
{
    internal class Program
    {
        private static Phong[] dsPhong;

        public static void NhapPhong()
        {
            Console.Write("Nhap so luong: ");
            int n = Int32.Parse(Console.ReadLine());
            dsPhong = new Phong[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1. Phong hang trung binh 2. Phong hang sang ");
                int chon = Int32.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    Console.WriteLine("Nhap phong hang trung binh");
                    PhongHangTB phongHangTb = new PhongHangTB();
                    phongHangTb.Nhap();
                    dsPhong[i] = phongHangTb;
                }
                else
                {
                    Console.WriteLine("Nhap phong hang sang");
                    PhongHangSang phongHangSang = new PhongHangSang();
                    phongHangSang.Nhap();
                    dsPhong[i] = phongHangSang;
                }
                Console.Clear();
            }
        }

        public static void Hien()
        {
            for (int i = 0; i < dsPhong.Length; i++)
            {
                if (dsPhong[i] is PhongHangTB)
                {
                    ((PhongHangTB)dsPhong[i]).Hien();
                }else if (dsPhong[i] is PhongHangSang)
                {
                    ((PhongHangSang)dsPhong[i]).Hien();
                }
            }
        }

        public static void Main(string[] args)
        {
            NhapPhong();
            Hien();
        }
    }
}