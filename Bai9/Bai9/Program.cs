using System;

namespace Bai9
{
    internal class Program
    {
        private static SinhVien[] dsSV;

        public static void Nhap()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            dsSV = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("1. Sinh vien cao dang 2. Sinh Vien dai hoc");
                int chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    Console.WriteLine("Nhap sinh vien cao dang");
                    SinhVienCD cd = new SinhVienCD();
                    cd.Nhap();
                    dsSV[i] = cd;
                }
                else
                {
                    Console.WriteLine("Nhap sinh vien dai hoc");
                    SinhVienDH dh = new SinhVienDH();
                    dh.Nhap();
                    dsSV[i] = dh;
                }

                Console.Clear();
            }
        }

        public static void Hien()
        {
            for (int i = 0; i < dsSV.Length; i++)
            {
                if (dsSV[i] is SinhVienCD)
                {
                    ((SinhVienCD) dsSV[i]).Hien();
                }
                else if (dsSV[i] is SinhVienDH)
                {
                    ((SinhVienDH) dsSV[i]).Hien();
                }
            }
        }


        public static void Main(string[] args)
        {
            Nhap();
            Hien();
        }
    }
}