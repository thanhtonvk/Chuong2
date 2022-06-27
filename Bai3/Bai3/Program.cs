using System;

namespace Bai3
{
    internal class Program
    {
        private static SinhVien[] DSSV;
        private static GiangVien[] DSGV;

        public static void NhapSinhVien()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            DSSV = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1) + " :");
                SinhVien sinhVien = new SinhVien();
                sinhVien.MaSv = "sv" + (i + 1);
                sinhVien.Nhap();
                DSSV[i] = sinhVien;
                Console.Clear();
            }
        }

        public static void NhapGiangVien()
        {
            Console.Write("Nhap so luong giang vien: ");
            int n = int.Parse(Console.ReadLine());
            DSGV = new GiangVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap giang vien thu " + (i + 1) + " :");
                GiangVien giangVien = new GiangVien();
                giangVien.MaGv = "gv" + (i + 1);
                giangVien.Nhap();
                DSGV[i] = giangVien;
                Console.Clear();
            }
        }

        public static void HienDSSV()
        {
            int n = DSSV.Length;
            Console.WriteLine("Danh sach sinh vien: ");
            for (int i = 0; i < n; i++)
            {
                DSSV[i].Hien();
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void HienDSGV()
        {
            int n = DSGV.Length;
            Console.WriteLine("Danh sach giang vien: ");
            for (int i = 0; i < n; i++)
            {
                DSGV[i].Hien();
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void ThongKe()
        {
            int slToanTin = 0;
            int slNgoaiNgu = 0;
            int n = DSSV.Length;
            for (int i = 0; i < n; i++)
            {
                if (DSSV[i].Khoa == "Ngoai Ngu") slNgoaiNgu++;
                else slToanTin++;
            }

            Console.WriteLine("So luong sinh vien khoa Toan Tin la " + slToanTin);
            Console.WriteLine("So luong sinh vien khoa Ngoai Ngu la " + slNgoaiNgu);
            Console.ReadKey();
            Console.Clear();
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Chon chuc nang: ");
                Console.WriteLine("1. Nhap sinh vien");
                Console.WriteLine("2. Nhap giang vien");
                Console.WriteLine("3. Hien sinh vien");
                Console.WriteLine("4. Hien giang vien");
                Console.WriteLine("5. Thong ke");
                Console.WriteLine("0. Thoat");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhapSinhVien();
                        break;
                    case 2:
                        NhapGiangVien();
                        break;
                    case 3:
                        HienDSSV();
                        break;
                    case 4:
                        HienDSGV();
                        break;
                    case 5:
                        ThongKe();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default: break;
                }
            }
        }
    }
}