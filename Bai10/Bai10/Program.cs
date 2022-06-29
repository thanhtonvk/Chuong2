using System;

namespace Bai10
{
    internal class Program
    {
        private static SinhVien[] dsSV = new SinhVien[0];
        private static double max = 0;

        public static void NhapSinhVien()
        {
            bool kt = true;
            while (kt)
            {
                Array.Resize(ref dsSV, dsSV.Length + 1);
                Console.WriteLine("1. Sinh vien CNTT 2.Sinh vien Vat Ly 3. Sinh vien Van 4.Thoat");
                int chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    SinhVienCNTT cntt = new SinhVienCNTT();
                    cntt.Nhap();
                    dsSV[dsSV.Length - 1] = cntt;
                }
                else if (chon == 2)
                {
                    SinhVienVL vl = new SinhVienVL();
                    vl.Nhap();
                    dsSV[dsSV.Length - 1] = vl;
                }
                else if (chon == 3)
                {
                    SinhVienVan van = new SinhVienVan();
                    van.Nhap();
                    dsSV[dsSV.Length - 1] = van;
                }
                else
                {
                    kt = false;
                }

                Console.Clear();
            }
        }

        public static void Hien()
        {
            Console.WriteLine("Danh sach sinh vien");
            for (int i = 0; i < dsSV.Length; i++)
            {
                if (dsSV[i] is SinhVienCNTT)
                {
                    SinhVienCNTT cntt = (SinhVienCNTT) dsSV[i];
                    cntt.Hien();
                    if (cntt.Dtb() > max) max = cntt.Dtb();
                }
                else if (dsSV[i] is SinhVienVL)
                {
                    SinhVienVL vl = (SinhVienVL) dsSV[i];
                    vl.Hien();
                    if (vl.Dtb() > max) max = vl.Dtb();
                }
                else if (dsSV[i] is SinhVienVan)
                {
                    SinhVienVan van = (SinhVienVan) dsSV[i];
                    van.Hien();
                    if (van.Dtb() > max) max = van.Dtb();
                }
            }
        }

        public static void HienDiemCao()
        {
            Console.WriteLine("Danh sach 3 sinh viem diem cao nhat");
            int dem = 0;
            for (int i = 0; i < dsSV.Length; i++)
            {
                if (dsSV[i] is SinhVienCNTT)
                {
                    SinhVienCNTT cntt = (SinhVienCNTT) dsSV[i];
                    if (cntt.Dtb() == max)
                    {
                        dem++;
                        cntt.Hien();
                    }
                }
                else if (dsSV[i] is SinhVienVL)
                {
                    SinhVienVL vl = (SinhVienVL) dsSV[i];

                    if (vl.Dtb() == max)
                    {
                        dem++;
                        vl.Hien();
                    }
                }
                else if (dsSV[i] is SinhVienVan)
                {
                    SinhVienVan van = (SinhVienVan) dsSV[i];

                    if (van.Dtb() == max)
                    {
                        dem++;
                        van.Hien();
                    }
                }

                if (dem == 3) break;
            }
        }

        public static void Main(string[] args)
        {
            NhapSinhVien();
            Hien();
            Console.ReadKey();
            Console.Clear();
            HienDiemCao();
        }
    }
}