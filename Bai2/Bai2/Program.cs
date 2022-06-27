using System;

namespace Bai2
{
    internal class Program
    {
        private static NhanVien[] nhanViens;
        private static int slHanhChinh, slCongTruong;

        public static void NhapSoLuong()
        {
            Console.Write("So luong nhan vien hanh chinh: ");
            slHanhChinh = int.Parse(Console.ReadLine());
            Console.Write("So luong nhan vien cong truong: ");
            slCongTruong = int.Parse(Console.ReadLine());
            nhanViens = new NhanVien [slCongTruong + slHanhChinh];
            Console.Clear();
        }

        public static void NhapNhanVienHanhChinh()
        {
            for (int i = 0; i < slHanhChinh; i++)
            {
                Console.WriteLine("Nhap nhan vien hanh chinh thu " + (i + 1) + " : ");
                NhanVienHanhChinh nv = new NhanVienHanhChinh();
                nv.Nhap();
                nhanViens[i] = nv;
                Console.Clear();
            }
        }

        public static void NhapNhanVienCongTruong()
        {
            for (int i = slHanhChinh; i < slHanhChinh + slCongTruong; i++)
            {
                Console.WriteLine("Nhap nhan vien cong truong thu " + (i - slHanhChinh + 1) + " : ");
                NhanVienCongTruong nv = new NhanVienCongTruong();
                nv.Nhap();
                nhanViens[i] = nv;
                Console.Clear();
            }
        }

        public static void HienDSNhanVien()
        {
            int n = nhanViens.Length;
            Console.WriteLine("Danh sach nhan vien hanh chinh: ");
            for (int i = 0; i < slHanhChinh; i++)
            {
                Console.WriteLine("Nhan vien hanh chinh ");
                NhanVienHanhChinh nv = nhanViens[i] as NhanVienHanhChinh;
                nv.Xuat1();
            }

            Console.WriteLine("Nhan vien cong truong ");
            for (int i = slHanhChinh; i < n; i++)
            {
                NhanVienCongTruong nv = nhanViens[i] as NhanVienCongTruong;
                nv.Xuat2();
            }

            Console.ReadKey();
            Console.Clear();
        }

        public static void Main(string[] args)
        {
            bool kt = true;
            while (kt)
            {
                Console.WriteLine("Chon chuc nang: ");
                Console.WriteLine("1. Nhap so luong nhan vien");
                Console.WriteLine("2. Nhap thong tin nhan vien hanh chinh");
                Console.WriteLine("3. Nhap thong tin nhan vien cong truong");
                Console.WriteLine("4. Hien thi danh sach nhan vien");
                Console.WriteLine("5. Thoat");
                int chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        NhapSoLuong();
                        break;
                    case 2:
                        NhapNhanVienHanhChinh();
                        break;
                    case 3:
                        NhapNhanVienCongTruong();
                        break;
                    case 4:
                        HienDSNhanVien();
                        break;
                    case 5:
                        kt = false;
                        break;
                    default: break;
                }
            }
        }
    }
}